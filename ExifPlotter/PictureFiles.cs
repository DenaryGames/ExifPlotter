using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifPlotter
{
    class PictureFiles : IEnumerator, IEnumerable
    {
        private List<Picture> pictures;
        int position = -1;

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
                return 0;
                /*
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
                */
            }
        }
        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < pictures.Count);
        }

        //IEnumerable
        public void Reset()
        { position = 0; }

        //IEnumerable
        public object Current
        {
            get { return pictures[position]; }
        }
    }
}
