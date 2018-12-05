using System.IO;

namespace Splitt
{
    public class FileData
    {
        /// <summary>
        /// Filename without extension
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Path without Filename
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// Extension
        /// </summary>
        public string Extension { get; private set; }

        /// <summary>
        /// Full filename, path, name and extension
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Fileinformation
        /// </summary>
        public FileInfo FileInformation { get; private set; }

        public FileData(string _filename)
        {
            FileName = _filename;
            Populate();
        }

        private void Populate()
        {
            FileInformation = new FileInfo(FileName);
            Path = FileInformation.DirectoryName;
            Name = System.IO.Path.GetFileNameWithoutExtension(FileInformation.Name);
            Extension = FileInformation.Extension;
        }
    }
}
