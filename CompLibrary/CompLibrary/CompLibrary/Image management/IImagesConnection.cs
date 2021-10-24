using System.Drawing;

namespace CompLibrary.Image_management
{
    public interface IImagesConnection
    {
        public string Save(Image ToSave);
    }
}
