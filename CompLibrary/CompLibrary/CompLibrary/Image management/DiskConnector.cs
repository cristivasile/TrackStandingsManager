using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CompLibrary.Image_management
{
    public class DiskConnector : IImagesConnection
    {
        /// <summary>
        /// Saves an image to disk and returns the path it was saved to.
        /// </summary>
        /// <param name="toSave">the image to be saved</param>
        /// <returns></returns>
        public string Save(Image toSave)
        {
            string savePath = DiskConnectorProcessor.GetRandomImagePath("jpg");
            ImageCodecInfo jpgEncoder = DiskConnectorProcessor.GetEncoder(ImageFormat.Jpeg);

            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            EncoderParameters EncoderParameters = new (1);

            EncoderParameter myEncoderParameter = new (myEncoder, 50L);
            EncoderParameters.Param[0] = myEncoderParameter;
            toSave.Save(savePath, jpgEncoder, EncoderParameters);

            return savePath;
        }

    }
}
