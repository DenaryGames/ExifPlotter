using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifPlotter
{
    class Picture
    {
        private string path;
        private int iso;
        private string fStop;
        private string exposureTime;
        private string program;
        private string metering;
        private string flashMode;
        private int focalLength;
        private DateTime dateTaken;

        public Picture(string path)
        {
            this.path = path;
            this.ReadExif();
        }

        private void ReadExif()
        {
            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(this.path);
            var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();

            this.iso = Convert.ToInt32(subIfdDirectory?.GetDescription(ExifDirectoryBase.TagIsoEquivalent));
            this.fStop = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagFnumber);
            this.exposureTime = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagExposureTime);
            this.program = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagExposureProgram);

        }
    }
}
