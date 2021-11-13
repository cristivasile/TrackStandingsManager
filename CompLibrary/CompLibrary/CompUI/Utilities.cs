﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI
{
    public static class Utilities
    {
        public static readonly int ScrollBarWidth = System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
        public static readonly FontFamily FontFamily = new("Sitka Display");
        public static readonly Font SmallText = new(
           FontFamily,
           14,
           FontStyle.Regular,
           GraphicsUnit.Pixel);

        public static readonly Font MediumText = new(
           FontFamily,
           16,
           FontStyle.Regular,
           GraphicsUnit.Pixel);

        public static readonly Font LargeText = new(
           FontFamily,
           18,
           FontStyle.Bold,
           GraphicsUnit.Pixel);

        public static readonly Font LargeTextBold = new(
           FontFamily,
           19,
           FontStyle.Bold,
           GraphicsUnit.Pixel);

        public static readonly Color FishBlue = Color.FromArgb(2, 74, 202);
        public static readonly Color BabyBlue = Color.FromArgb(228, 246, 255);
        /// <summary>
        /// Creates error label and appends it to a panel.
        /// </summary>
        /// <param name="error">Error message</param>
        /// <param name="parent">Panel to append to</param>

        public static void GenerateError(string error, FlowLayoutPanel parent)
        {
            Label newError = new();
            newError.Text = error;
            newError.Font = new Font("Consolas", 10);
            newError.ForeColor = System.Drawing.Color.Red;
            parent.Controls.Add(newError);
            newError.Width = Convert.ToInt32(0.75 * parent.Width);

        }

        /// <summary>
        /// Creates success label and appends it to a panel.
        /// </summary>
        /// <param name="success">Success message</param>
        /// <param name="panel">Panel to append to</param>
        public static void GenerateSuccess(string success, FlowLayoutPanel parent)
        {
            Label newSuccess = new();
            newSuccess.Text = success;
            newSuccess.Font = new Font("Consolas", 10);
            newSuccess.ForeColor = System.Drawing.Color.Green;
            parent.Controls.Add(newSuccess);
            newSuccess.Width = Convert.ToInt32(0.95 * parent.Width);
        }


        //Source = https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                using var wrapMode = new ImageAttributes();
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }

            return destImage;
        }

        public static void ResizeToFit(this PictureBox target)
        {
            //for maintaining aspect ratio;
            double ratio;
            //if image is wider than a square
            if (target.Image.Width > target.Image.Height)
            {
                ratio = Convert.ToDouble(target.Image.Height) / Convert.ToDouble(target.Image.Width);
                target.Image = Utilities.ResizeImage(target.Image, target.Width, Convert.ToInt32(ratio * target.Height));
            }
            //else if image is taller than a square
            else
            {
                ratio = Convert.ToDouble(target.Image.Width) / Convert.ToDouble(target.Image.Height);
                target.Image = Utilities.ResizeImage(target.Image, Convert.ToInt32(ratio * target.Width), target.Height);
            }

        }

        /// <summary>
        /// Appends label to panel with given parameters.
        /// </summary>
        public static void AddToPanel(this Label label, Panel panel, int widthDivide, Font font, Color textColor, ContentAlignment alignment, bool widthOverload = true)
        {
            if(widthOverload)
                label.Width = panel.Width / widthDivide;
            label.Height = panel.Height;
            label.Font = font;
            label.ForeColor = textColor;
            label.Padding = new Padding(0);
            label.TextAlign = alignment;
            panel.Controls.Add(label);
        }

        /// <summary>
        /// Adds a button to a panel and sets some properties.
        /// </summary>
        public static void AddToPanel(this Button button, Panel panel, int buttonSize)
        {
            button.BackColor = Color.Transparent;
            button.Margin = new Padding(0, 0, 10, 0);
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Text = "";
            button.Width = buttonSize;
            button.Height = buttonSize;
            button.Anchor = AnchorStyles.None;
            panel.Controls.Add(button);
        }

        public static Image GetCopyImage(string path)
        {
            using (Image img = Image.FromFile(path))
            {
                Bitmap bmp = new Bitmap(img);
                return bmp;
            }
        }
    }
}
