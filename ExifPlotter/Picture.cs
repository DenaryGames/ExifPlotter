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
        public string manufacturer;
        public string model;
        public string path;
        public int iso;
        public string fStop;
        public string exposureTime;
        public string program;
        public string metering;
        public string flashMode;
        public int focalLength;
        public DateTime dateTaken;
        public bool valid = true;

        public Picture(string path)
        {
            this.path = path;
            this.ReadExif();
        }

        private void ReadExif()
        {
            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(this.path);
            var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
            var mainIfdDirectory = directories.OfType<ExifIfd0Directory>().FirstOrDefault();

            try
            {
                this.dateTaken = Convert.ToDateTime(mainIfdDirectory.GetDescription(ExifDirectoryBase.TagDateTime));
                this.manufacturer = mainIfdDirectory.GetDescription(ExifDirectoryBase.TagMake);
                this.model = mainIfdDirectory.GetDescription(ExifDirectoryBase.TagModel);

                this.iso = Convert.ToInt32(subIfdDirectory?.GetDescription(ExifDirectoryBase.TagIsoEquivalent));
                this.fStop = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagFnumber);
                this.exposureTime = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagExposureTime);
                this.program = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagExposureProgram);
                this.metering = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagMeteringMode);
                this.flashMode = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagFlash);
                string tempFocal = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagFocalLength);
                this.focalLength = Convert.ToInt32(tempFocal.Substring(0, tempFocal.Length - 3));
                this.valid = true;
            }
            catch
            {
                this.valid = false;
                return;
            }
        }
    }
}
