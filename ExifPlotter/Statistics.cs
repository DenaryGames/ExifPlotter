using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifPlotter
{
    class Statistics
    {
        private PictureFiles picFiles;

        public Statistics(PictureFiles files)
        {
            this.picFiles = files;
        }

        public List<StatItem> GenerateFocalStatsBar()
        {
            List<StatItem> stats = new List<StatItem>();

            foreach(Picture pic in picFiles)
            {
                bool found = false;
                for(int i = 0; i < stats.Count; i++)
                {
                    if(stats.ElementAt(i).name.Equals(Convert.ToString(pic.focalLength)))
                    {
                        found = true;
                        stats.ElementAt(i).count++;
                    }
                }

                /*
                foreach(StatItem item in stats)
                {
                    if(item.name.Equals(pic.focalLength))
                    {
                        item.count++;
                        found = true;
                    }
                }
                */
                if(!found)
                {
                    stats.Add(new StatItem(Convert.ToString(pic.focalLength)));
                }
            }

            for (int i = 0; i < stats.Count; i++)
            {
                if (stats.ElementAt(i).name.Length == 2)
                {
                    stats.ElementAt(i).name = "0" + stats.ElementAt(i).name;
                }
            }


            return stats;
        }
    }

    public class StatItem : IEquatable<StatItem>, IComparable<StatItem>
    {
        public int count = 1;
        public string name = "";

        public StatItem(string name)
        {
            this.name = name;
        }

        public int CompareTo(StatItem other)
        {
            return this.name.CompareTo(other.name);
        }

        public bool Equals(StatItem other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }
    }
}
