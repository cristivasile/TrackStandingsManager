
using System.Drawing;

namespace CompLibrary.Image_management
{
    public class DiskConnector : IImagesConnection
    {
        /// <summary>
        /// Saves an image to disk and returns the path it was saved to
        /// </summary>
        /// <param name="toSave">the image to be saved</param>
        /// <returns></returns>
        public string Save(Image toSave)
        {
            string savePath = DiskConnectorProcessor.GetRandomImagePath();
            toSave.Save(savePath);
            return savePath;
        }

    }
}
