
using System;
using System.Drawing;
using System.Drawing.Imaging;

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
            string savePath = DiskConnectorProcessor.GetRandomImagePath("jpg");
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            toSave.Save(savePath, jpgEncoder, myEncoderParameters);

            return savePath;
        }

        private ImageCodecInfo GetEncoder(ImageFormat jpeg)
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
