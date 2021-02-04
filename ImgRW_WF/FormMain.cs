using ImageModifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgRW_WF
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream openStream = new FileStream(@"D:\b1628f6d7b35b7a957f3026c9459e22.jpg", FileMode.Open);
                Image source = Image.FromStream(openStream);
                openStream.Close();

                var re = Resizer.ResizeImage(source, 1400, 1800);
                source.Dispose();

                FileStream saveStream = new FileStream(@"D:\re.png", FileMode.Create);
                re.Save(saveStream, ImageFormat.Png);
                saveStream.Close();
                re.Dispose();

            }
            catch (Exception ex)
            {
                
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(Int32.Parse("FF0000", System.Globalization.NumberStyles.HexNumber));
            panel1.Invalidate();
        }
    }
}
