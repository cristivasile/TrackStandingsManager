using System;
using System.Drawing.Imaging;
using System.IO;

namespace CompLibrary.Image_management
{
    public static class DiskConnectorProcessor
    {
        /// <summary>
        /// returns an image save path along with a random .bmp file name
        /// </summary>
        /// <returns></returns>
        public static string GetRandomImagePath(string FileExtension = "png")
        {
            string uniqueFileName = string.Format(@"{0}.{1}", DateTime.Now.Ticks, FileExtension);
            return $"{FunctionLibrary.GetAppDirectory()}\\imgStorage\\{uniqueFileName}";
        }

        /// <summary>
        /// Checks if required directories exist and creates them if needed
        /// </summary>
        public static void CreateImageDirectories()
        {
            //checks if main app directory exists
            if (!Directory.Exists(FunctionLibrary.GetAppDirectory()))
            {
                Directory.CreateDirectory(FunctionLibrary.GetAppDirectory());
            }
            //checks if img storage directory exists
            if (!Directory.Exists($"{FunctionLibrary.GetAppDirectory()}\\imgStorage"))
            {
                Directory.CreateDirectory($"{FunctionLibrary.GetAppDirectory()}\\imgStorage");
            }
        }

        public static ImageCodecInfo GetEncoder(ImageFormat jpeg)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == jpeg.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
