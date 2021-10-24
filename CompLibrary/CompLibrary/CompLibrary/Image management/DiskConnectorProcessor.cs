using System;
using System.IO;

namespace CompLibrary.Image_management
{
    public static class DiskConnectorProcessor
    {
        /// <summary>
        /// returns an image save path along with a random .bmp file name
        /// </summary>
        /// <returns></returns>
        public static string GetRandomImagePath()
        {
            string uniqueFileName = string.Format(@"{0}.bmp", DateTime.Now.Ticks);
            return $"{FunctionLibrary.GetAppDirectory()}\\bmpStorage\\{uniqueFileName}";
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
            //checks if json storage directory exists
            if (!Directory.Exists($"{FunctionLibrary.GetAppDirectory()}\\bmpStorage"))
            {
                Directory.CreateDirectory($"{FunctionLibrary.GetAppDirectory()}\\bmpStorage");
            }
        }
    }
}
