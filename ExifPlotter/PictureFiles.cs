using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifPlotter
{
    class PictureFiles
    {
        private List<Picture> pictures;
        private int duplcates;
        private int noExif;

        public PictureFiles()
        {
            pictures = new List<Picture>();
        }

        public void Add(string path)
        {
            pictures.Add(new Picture(path));
        }

        public int PictureCount
        {
            get
            {
                return pictures.Count;
            }
        }

        // List of files
        // Statistics
    }
}
