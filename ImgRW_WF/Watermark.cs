using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgRW_WF
{
    class Watermark
    {
        public event EventHandler<string> WMString_Changed;
        private string wMString;
        public string WMString
        {
            get => wMString; set
            {
                wMString = value;
                WMString_Changed?.Invoke(this, wMString);
            }
        }

        //public event EventHandler<int> WMStringSize_Changed;
        //private int wMStringSize;
        //public int WMStringSize
        //{
        //    get { return wMStringSize; }
        //    set 
        //    { 
        //        wMStringSize = value;
        //        WMStringSize_Changed?.Invoke(this, wMStringSize);
        //    }
        //}

        public event EventHandler<Point> WMStringLocation_Changed;
        private Point wMStringLocation;
        public Point WMStringLocation
        {
            get { return wMStringLocation; }
            set 
            { 
                wMStringLocation = value;
                WMStringLocation_Changed?.Invoke(this, wMStringLocation);
            }
        }



        public event EventHandler<Color> WMStringColor_Changed;
        private Color wMStringColor;
        public Color WMStringColor
        {
            get { return wMStringColor; }
            set { wMStringColor = value; WMStringColor_Changed?.Invoke(this, WMStringColor); }
        }

        public event EventHandler<bool> WMStringFrame_Changed;
        private bool wMStringFrame;
        public bool WMStringFrame
        {
            get { return wMStringFrame; }
            set { wMStringFrame = value; WMStringFrame_Changed?.Invoke(this, wMStringFrame); }
        }

        public event EventHandler<int> WMStringFrameThick_Changed;
        private int wMStringFrameThick;
        public int WMStringFrameThick
        {
            get { return wMStringFrameThick; }
            set { wMStringFrameThick = value; WMStringFrameThick_Changed?.Invoke(this, wMStringFrameThick); }
        }

        //Image
        public event EventHandler<Image> WMImage_Changed;
        private Image wMImage;
        public Image WMImage
        {
            get { return wMImage; }
            set 
            { 
                wMImage = value;
                WMImage_Changed?.Invoke(this, wMImage);
            }
        }

        public event EventHandler<Point> WMImageLocation_Changed;
        private Point wMImageLocation;
        public Point WMImageLocation
        {
            get { return wMImageLocation; }
            set 
            { 
                wMImageLocation = value;
                WMImageLocation_Changed?.Invoke(this, wMImageLocation);
            }
        }
    }
}
