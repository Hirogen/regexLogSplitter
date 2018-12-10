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

        // TODO should be configurable

        /// <summary>
        /// static time filter regex
        /// </summary>
        private const string TIME_FILTER_REGEX = @"(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}\.\d{3})";

        #endregion

        #region Private Fields

        /// <summary>
        /// Temporary collection of log files, so they can be processed multi threaded
        /// </summary>
        private BlockingCollection<string> _tempLines = new BlockingCollection<string>();

        #endregion

        #region Ctor

        public Split(FileData filename)
        {
            Filename = filename;
        }

        #endregion

        #region Properties / Indexers

        /// <summary>
        /// Gets or sets the end time for the time frame
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Gets the extracted Lines for saving
        /// </summary>
        public BlockingCollection<string> ExtractedLines { get; private set; } = new BlockingCollection<string>();

        /// <summary>
        /// Gets the information of the logfile
        /// </summary>
        public FileData Filename { get; }

        /// <summary>
        /// Gets or sets the Regex for Removing a Line from Log
        /// </summary>
        public string RemoveLineRegex { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether the lines should be removed or not
        /// </summary>
        public bool RemoveLines { get; set; }

        /// <summary>
        /// Gets or sets the start time for the time frame
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Start the extraction process
        /// </summary>
        /// <param name="cancellationToken">Cancels the process</param>
        public void Start(CancellationToken cancellationToken)
        {
            Task readLines = Task.Factory.StartNew(() => ReadingDataFromLogfile(cancellationToken), cancellationToken);
            Task processLines = Task.Factory.StartNew(() => ProcessLines(cancellationToken), cancellationToken);
            Task writingLines = Task.Factory.StartNew(() => WritingDataToFile(cancellationToken), cancellationToken);


            Task.WaitAll(readLines, processLines, writingLines);

            if (processLines.IsCompleted && _tempLines.IsCompleted && (_tempLines.Count == 0 || _tempLines.Count < 0))
            {
                _tempLines = new BlockingCollection<string>();
            }

            if (writingLines.IsCompleted && ExtractedLines.IsCompleted && (ExtractedLines.Count == 0 || ExtractedLines.Count < 0))
            {
                ExtractedLines = new BlockingCollection<string>();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates a filename based on the current time
        /// </summary>
        /// <param name="now">should it be the current time?</param>
        /// <returns>the filename</returns>
        private string CreateNewFileName(bool now)
        {
            string startTime = DateTime.Now.ToString("g", new CultureInfo("de-DE")).Replace(" ", "_").Replace(":", string.Empty);

            return Filename.Path + @"\" + Filename.Name + @"_" + startTime + Filename.Extension;
        }

        /// <summary>
        /// Creates the new filename based on the selected time window
        /// </summary>
        /// <returns>the filename</returns>
        private string CreateNewFileName()
        {
            string startTime = StartTime.ToString("g", new CultureInfo("de-DE"));
            string endTime = EndTime.ToString("g", new CultureInfo("de-DE"));

            startTime = startTime.Replace(" ", "_").Replace(":", string.Empty);
            endTime = endTime.Replace(" ", "_").Replace(":", string.Empty);

            return Filename.Path + @"\" + Filename.Name + @"_" + startTime + @"_to_" + endTime + Filename.Extension;
        }

        /// <summary>
        /// Check if the current line is within the time window and save it to a blockingCollection
        /// </summary>
        /// <param name="line">current log line</param>
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

        /// <summary>
        /// Check if the current line is within the time window and save it to a blockingCollection
        /// </summary>
        /// <param name="line">current log line</param>
        private void ExtractTimeLogFile(string line, bool removeLines)
        {
            // If Match, we ignore the line
            Match m = Regex.Match(line, RemoveLineRegex);

            if (!m.Success)
            {
                ExtractedLines.Add(line);
            }
        }

        /// <summary>
        /// Process the log lines multi threaded if possible
        /// </summary>
        /// <param name="cancellationToken">Cancels the process</param>
        private void ProcessLines(CancellationToken cancellationToken)
        {
            Parallel.ForEach(
                _tempLines.GetConsumingEnumerable().AsParallel().AsOrdered(),
                (line, loopState) =>
                {
                    if (RemoveLines)
                    {
                        ExtractTimeLogFile(line, RemoveLines);
                    }
                    else
                    {
                        ExtractTimeLogFile(line);
                    }

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

        /// <summary>
        /// Read the log lines
        /// </summary>
        /// <param name="cancellationToken">Cancels the process</param>
        private void ReadingDataFromLogfile(CancellationToken cancellationToken)
        {
            if (Filename.FileInformation.Exists)
            {
                _tempLines = new BlockingCollection<string>();

                foreach (string line in File.ReadLines(Filename.FileInformation.FullName))
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

        /// <summary>
        /// Write data to the new file
        /// </summary>
        /// <param name="cancellationToken">Cancels the process</param>
        private void WritingDataToFile(CancellationToken cancellationToken)
        {
            string filename;

            filename = RemoveLines ? CreateNewFileName(RemoveLines) : CreateNewFileName();

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

        #endregion
    }
}
