using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExifPlotter
{
    class Util
    {
        public PictureFiles FindFiles(string path, string[] pattern, bool subDirs)
        {
            SearchOption useSubDirs = SearchOption.TopDirectoryOnly;

            // Create PictureFiles object
            PictureFiles picFiles = new PictureFiles();

            // Find files
            if (subDirs)
            {
                useSubDirs = SearchOption.AllDirectories;
            }

            var files = Directory.GetFiles(path, "*", useSubDirs)
                .Where(file => pattern.Any(file.ToUpper().EndsWith))
                .ToList();

            // Add individual pictures
            // Populate PictureFiles statistics

            return null;
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
