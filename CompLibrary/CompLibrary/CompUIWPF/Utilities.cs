using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUIWPF
{
    public static class Utilities
    {
        /// <summary>
        /// Returns copy image loaded from disk. Used to close image files after load.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Image GetCopyImage(string path)
        {
            using Image img = Image.FromFile(path);
            Bitmap bmp = new(img);
            return bmp;
        }

        /// <summary>
        /// Filters digits from given string
        /// </summary>
        public static string FilterDigits(this string toFilter)
        {
            string FilteredString = "";

            foreach (char character in toFilter)
                if (char.IsDigit(character))
                    FilteredString += character;

            return FilteredString;
        }

        /// <summary>
        /// Adds 0-es at the end of a string until the required length is achieved.
        /// </summary>
        /// <returns></returns>
        public static string PadZeroes(this string toPad, int requiredLength)
        {
            while (toPad.Length != requiredLength)
                toPad += '0';

            return toPad;
        }
    }
}
