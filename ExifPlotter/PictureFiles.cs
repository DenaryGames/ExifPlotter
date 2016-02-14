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

        public PictureFiles()
        {
            pictures = new List<Picture>();
        }

        public void Add(string path)
        {
            pictures.Add(new Picture(path));
        }

        // List of files
        // Statistics
        public int noExif
        {
            get
            {
                int count = 0;
                foreach(Picture pic in pictures)
                {
                    if(!pic.valid)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int pictureCount
        {
            get
            {
                return pictures.Count;
            }
        }

        public int duplicates
        {
            get
            {
                int count = 0;
                foreach(Picture pic in pictures)
                {
                    foreach(Picture compare in pictures)
                    {
                        if(pic.dateTaken.Equals(compare.dateTaken))
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
    }
}
