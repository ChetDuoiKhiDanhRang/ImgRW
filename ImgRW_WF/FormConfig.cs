using ImageModifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgRW_WF
{
    public partial class FormConfig : Form
    {
        public List<string> FontNames { get; set; }

        public event EventHandler<string> LanguageChanged;
        private string language;
        public string Language
        {
            get => language;
            set
            {
                language = value;
                LanguageChanged?.Invoke(this, language);
            }
        }


        public event EventHandler<ResizeModes> ResizeModeChanged;
        private ResizeModes resizeMode;
        public ResizeModes ResizeMode
        {
            get { return resizeMode; }
            set { resizeMode = value; ResizeModeChanged?.Invoke(this, resizeMode); }
        }

        Watermark WM;

        public event EventHandler<bool> Draw_WS_String_Changed;
        private bool draw_WS_String;
        public bool Draw_WS_String
        {
            get { return draw_WS_String; }
            set { draw_WS_String = value; Draw_WS_String_Changed?.Invoke(this, draw_WS_String); }
        }

        public event EventHandler<Font> WStringFont_Changed;
        private Font wStringFont;
        public Font WStringFont
        {
            get { return wStringFont; }
            set { wStringFont = value; WStringFont_Changed?.Invoke(this, wStringFont); }
        }




        public event EventHandler<bool> Draw_WS_Image_Changed;
        private bool draw_WS_Image;
        public bool Draw_WS_Image
        {
            get { return draw_WS_Image; }
            set { draw_WS_Image = value; Draw_WS_Image_Changed?.Invoke(this, draw_WS_String); }
        }


        Dictionary<string, ListViewItem> files;
        public FormConfig()
        {
            InitializeComponent();
            WM = new Watermark();
            
            files = new Dictionary<string, ListViewItem>();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadSettings();

            cmbFont.Invoke((Action)(() =>
            {
                FontNames = (new InstalledFontCollection()).Families.Select(f => f.Name).ToList();
                FontNames.Sort();
                cmbFont.DataSource = FontNames;
            }));

        }

        private void LoadSettings()
        {
            //throw new NotImplementedException();
        }

        private void SaveSettings()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream openStream = new FileStream(@"D:\b1628f6d7b35b7a957f3026c9459e22.jpg", FileMode.Open);
                Image source = Image.FromStream(openStream);
                openStream.Dispose();
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

        //Draw Watermark String or not
        private void ckbString_CheckedChanged(object sender, EventArgs e)
        {
            panelWatermarkString.Enabled = ckbString.Checked;
        }

        //Binding location Watermark String
        private void rdbLocation_CheckedChanged(object sender, EventArgs e)
        {
            nudWSLocationX.Enabled = nudWSLocationY.Enabled = rdbWSLocation.Checked;
        }

        //Draw Watermark Image or not
        private void ckbWatermarkImage_CheckedChanged(object sender, EventArgs e)
        {
            panelWatermarkImage.Enabled = ckbWatermarkImage.Checked;
        }


        //Resize images or not
        private void ckbResize_CheckedChanged(object sender, EventArgs e)
        {
            panelResize.Enabled = ckbResize.Checked;
        }

        //Set ResizeMode
        private void radResizeMode_CheckedChanged(object sender, EventArgs e)
        {
            var ob = (RadioButton)sender;
            if (!ob.Checked) return;
            if (ob.Name == radFixHeight.Name)
            {
                ResizeMode = ResizeModes.FixHeight;
            }
            else if (ob.Name == radFixWidth.Name)
            {
                ResizeMode = ResizeModes.FixWidth;
            }
            else if (ob.Name == radScale.Name)
            {
                ResizeMode = ResizeModes.Scale;
            }

        }


        //add and remove files list
        private void ctmMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ctmMenu.Visible = false;
            if (e.ClickedItem.Name == "ctmAddFiles")
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Support Image files|*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.tiff";
                    ofd.RestoreDirectory = true;
                    ofd.Multiselect = true;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var item in ofd.FileNames)
                        {
                            if (files.ContainsKey(item))
                            {
                                continue;
                            }
                            using (FileStream fileStream = new FileStream(item, FileMode.Open))
                            {
                                Image i = Image.FromStream(fileStream);
                                FileInfo fi = new FileInfo(item);
                                ListViewItem li = new ListViewItem(fi.Name);
                                li.SubItems.Add(CalculateBytes(fi.Length));
                                li.SubItems.Add(i.Width.ToString() + "×" + i.Height.ToString());
                                li.Tag = item;
                                i.Dispose();
                                files.Add(item, li);
                            }
                        }

                        lsvFiles.Items.Clear();
                        foreach (var item in files)
                        {
                            lsvFiles.Items.Add(item.Value);
                        }
                        for (int i = 0; i < lsvFiles.Columns.Count; i++)
                        {
                            lsvFiles.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                        }
                    }
                }
            }
            else if (e.ClickedItem.Name == "ctmDeleteSelected")
            {
                if (lsvFiles.SelectedItems.Count == 0) return;
                foreach (ListViewItem item in lsvFiles.SelectedItems)
                {
                    files.Remove((string)item.Tag);
                    lsvFiles.Items.Remove(item);
                }
            }
            else if (e.ClickedItem.Name == "ctmClearList")
            {
                files.Clear();
                lsvFiles.Items.Clear();
            }
        }

        //Length of files in friendly
        string CalculateBytes(long _value)
        {
            int count = 0;
            long cal = _value;
            while (cal >= 1024)
            {
                cal /= 1024;
                count++;
            }

            string rs;
            switch (count)
            {
                case 0:
                    rs = "Bytes";
                    break;
                case 1:
                    rs = "KB";
                    break;
                case 2:
                    rs = "MB";
                    break;
                case 3:
                    rs = "GB";
                    break;
                case 4:
                    rs = "TB";
                    break;

                case 5:
                    rs = "PB";
                    break;

                default:
                    rs = "...";
                    break;
            }

            return cal.ToString("0") + rs;
        }

        private void lsvFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lsvFiles.SelectedItems.Count == 0) return;
                foreach (ListViewItem item in lsvFiles.SelectedItems)
                {
                    files.Remove((string)item.Tag);
                    lsvFiles.Items.Remove(item);
                }
            }
        }
    }
}
