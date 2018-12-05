using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Splitt
{
    public class Split
    {
        #region Static/Constants

        private const string TIME_FILTER_REGEX = @"(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}\.\d{3})";

        #endregion

        #region Private Fields

        private readonly FileData _filename;

        private BlockingCollection<string> _tempLines = new BlockingCollection<string>();

        #endregion

        #region Ctor

        public Split(FileData filename)
        {
            _filename = filename;
        }

        #endregion

        #region Properties / Indexers

        public DateTimeOffset EndTime { get; set; }

        public BlockingCollection<string> ExtractedLines { get; } = new BlockingCollection<string>();

        public DateTimeOffset StartTime { get; set; }

        #endregion

        #region Public Methods

        public void Start(CancellationToken cancellationToken)
        {
            Task readLines = Task.Factory.StartNew(() => ReadingDataFromLogfile(cancellationToken), cancellationToken);
            Task processLines = Task.Factory.StartNew(() => ProcessLines(cancellationToken), cancellationToken);
            Task writingLines = Task.Factory.StartNew(() => WritingDataToFile(cancellationToken), cancellationToken);

            Task.WaitAll(readLines, processLines, writingLines);
        }

        #endregion

        #region Private Methods

        private void ExtractTimeLogFile(string line)
        {
            // All lines with Timestamp
            Match m = Regex.Match(line, TIME_FILTER_REGEX);

            if (m.Success)
            {
                if (DateTimeOffset.TryParse(m.Groups[0].Value.Trim(), out DateTimeOffset parsedTime))
                {
                    if (parsedTime > StartTime && parsedTime < EndTime)
                    {
                        ExtractedLines.Add(line);
                    }
                }
            }
        }

        private void ProcessLines(CancellationToken cancellationToken)
        {
            Parallel.ForEach(
                _tempLines.GetConsumingEnumerable().AsParallel().AsOrdered(),
                (line, loopState) =>
                {
                    ExtractTimeLogFile(line);

                    if (cancellationToken.IsCancellationRequested)
                    {
                        loopState.Break();
                    }
                });

            if (_tempLines.IsCompleted)
            {
                ExtractedLines.CompleteAdding();
            }
        }

        private void ReadingDataFromLogfile(CancellationToken cancellationToken)
        {
            if (_filename.FileInformation.Exists)
            {
                _tempLines = new BlockingCollection<string>();

                foreach (string line in File.ReadLines(_filename.FileInformation.FullName))
                {
                    _tempLines.Add(line, cancellationToken);

                    if (cancellationToken.IsCancellationRequested)
                    {
                        break;
                    }
                }

                _tempLines.CompleteAdding();
            }
        }

        private void WritingDataToFile(CancellationToken cancellationToken)
        {
            string filename = CreateNewFileName();

            if (!File.Exists(filename))
            {
                using (File.Create(filename))
                {
                    // TODO LOG File Created
                }
            }

            using (FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    while (!ExtractedLines.IsCompleted)
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            // TODO ADD LOGGIN for BREAK
                            break;
                        }

                        ExtractedLines.TryTake(out string line);

                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
        }

        private string CreateNewFileName()
        {
            string startTime = StartTime.ToString("g", new CultureInfo("de-DE"));
            string endTime = EndTime.ToString("g", new CultureInfo("de-DE"));

            startTime = startTime.Replace(" ", "_").Replace(":", string.Empty);
            endTime = endTime.Replace(" ", "_").Replace(":", string.Empty);

            return _filename.Path + @"\" + _filename.Name + @"_" + startTime + @"_to_" + endTime + _filename.Extension;
        }

        #endregion
    }
}
