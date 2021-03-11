using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageModifier
{
    public class Resizer
    {
        public static double CalculateRatio(Image sourceImage)
        {
            var r = (double)sourceImage.Width / sourceImage.Height;

            return r;
        }

        public static Image ResizeImage(Image sourceImage, Size destSize)
        {
            return ResizeImage(sourceImage, destSize.Width, destSize.Height);
        }

        public static Bitmap ResizeImage(Bitmap sourceImage, Size destSize)
        {
            return ResizeImage(sourceImage, destSize.Width, destSize.Height);
        }

        public static Image ResizeImage(Image sourceImage, int destW, int destH)
        {
            Image clone = sourceImage.Clone() as Image;
            Bitmap result = new Bitmap(destW, destH, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g               = Graphics.FromImage(result);
            g.SmoothingMode          = SmoothingMode.AntiAlias;
            g.InterpolationMode      = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode        = PixelOffsetMode.HighQuality;
            g.CompositingQuality     = CompositingQuality.GammaCorrected;

            g.Clear(Color.Transparent);
            g.DrawImage(sourceImage, new Rectangle(0, 0, destW, destH), new Rectangle(0, 0, clone.Width, clone.Height), GraphicsUnit.Pixel);
            clone.Dispose();
            g.Dispose();

            return result;
        }

        public static Bitmap ResizeImage(Bitmap sourceImage, int destW, int destH)
        {
            Bitmap clone = sourceImage.Clone() as Bitmap;
            Bitmap result = new Bitmap(destW, destH, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(result);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.GammaCorrected;

            g.Clear(Color.Transparent);
            g.DrawImage(sourceImage, new Rectangle(0, 0, destW, destH), new Rectangle(0, 0, clone.Width, clone.Height), GraphicsUnit.Pixel);
            clone.Dispose();
            g.Dispose();

            return result;
        }
    }
}
