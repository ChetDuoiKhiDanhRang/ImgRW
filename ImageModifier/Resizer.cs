﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageModifier
{
    public class Resizer
    {
        public double CalculateRatio(Image sourceImage)
        {
            var r = (double)sourceImage.Width / sourceImage.Height;

            return r;
        }

        public static Image ResizeImage(Image sourceImage, int destW, int destH)
        {
            Image clone = sourceImage.Clone() as Image;
            Bitmap result = new Bitmap(destW, destH, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(result);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.CompositingQuality = CompositingQuality.GammaCorrected;
            //ImageAttributes attrib = new ImageAttributes();
            //attrib.SetWrapMode(WrapMode.Clamp);
            g.DrawImage(clone, new Rectangle(0, 0, destW, destH), new Rectangle(0, 0, clone.Width, clone.Height), GraphicsUnit.Pixel);
            clone.Dispose();
            g.Dispose();

            return result;
        }
    }
}
