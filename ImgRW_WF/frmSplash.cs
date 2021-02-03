using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageModifier;

namespace ImgRW_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\Z.NguyenNgocCuong\Pictures\b1628f6d7b35b7a957f3026c9459e220.jpg");

            Image resized = (new Resizer()).ResizeImage(img, 700, 650);

            resized.Save(@"%userprofile%\Pictures\resized.png", ImageFormat.Png);

        }
    }
}
