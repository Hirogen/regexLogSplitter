using System.IO;

namespace Splitt
{
    public class FileData
    {
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData"/> class
        /// </summary>
        /// <param name="filename">Filename for the file information</param>
        public FileData(string filename)
        {
            FileName = filename;
            Populate();
        }

        #endregion

        #region Properties / Indexers

        /// <summary>
        /// Gets the extension
        /// </summary>
        public string Extension { get; private set; }

        /// <summary>
        /// Gets the file information
        /// </summary>
        public FileInfo FileInformation { get; private set; }

        /// <summary>
        /// Gets the  full filename, path, name and extension
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Gets the filename without extension
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the path without filename
        /// </summary>
        public string Path { get; private set; }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populates the properties of the class
        /// </summary>
        private void Populate()
        {
            FileInformation = new FileInfo(FileName);
            Path = FileInformation.DirectoryName;
            Name = System.IO.Path.GetFileNameWithoutExtension(FileInformation.Name);
            Extension = FileInformation.Extension;
        }

        #endregion
    }
}
