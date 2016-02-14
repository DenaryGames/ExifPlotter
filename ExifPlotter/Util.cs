using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExifPlotter
{
    ///<summary>
    /// Util class for handling various
    /// file reading etc. tasks.
    ///</summary>
    class Util
    {
        public void FindFiles(string path, string[] pattern, bool subDirs, PictureFiles picFiles)
        {
            SearchOption useSubDirs = SearchOption.TopDirectoryOnly;

            // Find files
            if (subDirs)
            {
                useSubDirs = SearchOption.AllDirectories;
            }

            var files = Directory.GetFiles(path, "*", useSubDirs)
                .Where(file => pattern.Any(file.ToUpper().EndsWith))
                .ToList();

            // Add individual pictures
            foreach(string pic in files)
            {
                picFiles.Add(pic);
            }

            // Populate PictureFiles statistics
        }

        public string[] GetPattern(ListBox.SelectedObjectCollection selectedItems)
        {
            string[] pattern = new string[selectedItems.Count];
            int i = 0;

            foreach (string fileType in selectedItems)
            {
                pattern[i] = fileType;
                i++;
            }

            return pattern;
        }
    }
}
