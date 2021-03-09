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

        public enum LocationModes
        {
            Custom,
            TopLeft,
            TopCenter,
            TopRight,
            MiddleLeft,
            MiddleCenter,
            MiddleRight,
            BottomLeft,
            BottomCenter,
            BottomRight
        }


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

        Dictionary<string, ListViewItem> files;
        public FormConfig()
        {
            InitializeComponent();
            //PreviewLayer = new Bitmap(pibPreview.BackgroundImage.Width, pibPreview.BackgroundImage.Height, PixelFormat.Format32bppArgb);

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
                    ofd.Filter = "Image files|*.png;*.bmp;*.jpg;*.jpeg;*.gif;*.tiff";
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

        //delete selected files
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

        //changed font
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFont.SelectedIndex < 0) return;
            string fontName = (string)cmbFont.SelectedItem;
            FontFamily fm = new FontFamily(fontName);
            ckbBold.Enabled = fm.IsStyleAvailable(FontStyle.Bold);
            ckbItalic.Enabled = fm.IsStyleAvailable(FontStyle.Italic);
            ckbUnderline.Enabled = fm.IsStyleAvailable(FontStyle.Underline);
            GenerateFont();
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            GenerateFont();
        }

        //Generate font and style from UI controls
        Font wsFont;
        FontStyle wsFontStyle;
        private void GenerateFont()
        {
            var bold = (ckbBold.Enabled & ckbBold.Checked) ? 1 : 0;
            var italic = (ckbItalic.Enabled & ckbItalic.Checked) ? 2 : 0;
            var underline = (ckbUnderline.Enabled & ckbUnderline.Checked) ? 4 : 0;

            wsFont = new Font((string)cmbFont.SelectedItem, (float)nudFontSize.Value);
            wsFontStyle = (FontStyle)(bold | italic | underline);
        }

        private void pibWatermarkImage_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void pibWatermarkImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image files|*.png;*.bmp;*.jpeg;*.jpg;*.gif;*.tiff",
                Multiselect = false,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    Image background = Image.FromStream(fs);
                    pibWatermarkImage.BackgroundImage?.Dispose();
                    pibWatermarkImage.BackgroundImage = background;
                }
            }
            ofd.Dispose();
        }

        //events needs to draw preview
        string content;
        private void txbWString_TextChanged(object sender, EventArgs e)
        {
            if (txbWString.Text.Length == 0) return;
            content = txbWString.Text;
            DrawWatermarkLayer(PreviewLayer);
        }

        Bitmap PreviewLayer;
        private void DrawWatermarkLayer(Bitmap previewLayer)
        {
            if (ckbString.Checked)
            {
                DrawStringWatermark(previewLayer);
            }
            if (ckbWatermarkImage.Checked)
            {
                DrawImageWatermark(previewLayer);
            }
        }

        private void DrawImageWatermark(Bitmap previewLayer)
        {
            //throw new NotImplementedException();
        }


        
        LocationModes StringLocationMode;
        private void DrawStringWatermark(Bitmap previewLayer)
        {
            if (previewLayer == null) return;

            Graphics graph = Graphics.FromImage(previewLayer);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graph.TextRenderingHint = TextRenderingHint.AntiAlias;
            var size = graph.MeasureString(content, wsFont);
            PointF location;
            switch (StringLocationMode)
            {
                case LocationModes.Custom:
                    location = new PointF((float)nudWSLocationX.Value, (float)nudWSLocationY.Value);
                    break;
                case LocationModes.TopLeft:
                    location = new PointF(0, 0);
                    break;
                case LocationModes.TopCenter:
                    location = new PointF((previewLayer.Width - size.Width) / 2, drawStringFrame ? (float)(frameLineWidth / 2) : 0);
                    break;
                case LocationModes.TopRight:
                    location = new PointF((previewLayer.Width - size.Width) - (drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        ckbFrame.Checked ? (float)(frameLineWidth / 2) : 0);
                    break;
                case LocationModes.MiddleLeft:
                    location = new PointF(0, (previewLayer.Height - size.Height) / 2);
                    break;
                case LocationModes.MiddleCenter:
                    location = new PointF((previewLayer.Width - size.Width) / 2, (previewLayer.Height - size.Height) / 2);
                    break;
                case LocationModes.MiddleRight:
                    location = new PointF((previewLayer.Width - size.Width) - (drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        (previewLayer.Height - size.Height) / 2);
                    break;
                case LocationModes.BottomLeft:
                    location = new PointF(0, (previewLayer.Height - size.Height) - (drawStringFrame ? (float)frameLineWidth / 2 : 0));
                    break;
                case LocationModes.BottomCenter:
                    location = new PointF((previewLayer.Width - size.Width) / 2,
                        (previewLayer.Height - size.Height) - (drawStringFrame ? (float)frameLineWidth / 2 : 0));
                    break;
                case LocationModes.BottomRight:
                    location = new PointF((previewLayer.Width - size.Width) - (drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        (previewLayer.Height - size.Height) - (drawStringFrame ? (float)frameLineWidth / 2 : 0));
                    break;
                default:
                    location = new PointF(0, 0);
                    break;
            }
            graph.TranslateTransform(location.X, location.Y);
            graph.RotateTransform(0 - stringRotateAngle);

            using (Brush b = new SolidBrush(stringColor))
            {
                graph.DrawString(content, wsFont, b, 0, 0);
                if (drawStringFrame)
                {
                    using (Pen p = new Pen(b))
                    {
                        p.Width = frameLineWidth;
                        graph.DrawRectangle(p, 0, 0, size.Width, size.Height);
                    }
                }
            }

            graph.Dispose();
        }

        private void pibPreview_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (pibPreview.BackgroundImage == null) return;
            PreviewLayer?.Dispose();
            PreviewLayer = new Bitmap(pibPreview.BackgroundImage.Width, pibPreview.BackgroundImage.Height, PixelFormat.Format32bppArgb);
            DrawWatermarkLayer(PreviewLayer);

            pibPreview.Image = PreviewLayer;
        }

        bool drawStringFrame;
        private void ckbFrame_CheckedChanged(object sender, EventArgs e)
        {
            drawStringFrame = ckbFrame.Checked;
            DrawWatermarkLayer(PreviewLayer);
        }

        float frameLineWidth;
        private void nudFrameSize_ValueChanged(object sender, EventArgs e)
        {
            frameLineWidth = (float)nudFrameSize.Value;
            DrawWatermarkLayer(PreviewLayer);
        }

        //String watermark locations
        private void rdbStingLocationModes_CheckedChanged(object sender, EventArgs e)
        {

            var r = (RadioButton)sender;
            if (r.Name == rdbWSLocation.Name)
            {
                nudWSLocationX.Enabled = nudWSLocationY.Enabled = rdbWSLocation.Checked;
                StringLocationMode = LocationModes.Custom;
            }
            else if (r.Name == rdbTopLeft.Name)
            {
                StringLocationMode = LocationModes.TopLeft;
            }
            else if (r.Name == rdbTopCenter.Name)
            {
                StringLocationMode = LocationModes.TopCenter;
            }
            else if (r.Name == rdbTopRight.Name)
            {
                StringLocationMode = LocationModes.TopRight;
            }
            else if (r.Name == rdbMiddleLeft.Name)
            {
                StringLocationMode = LocationModes.MiddleLeft;
            }
            else if (r.Name == rdbMiddleCenter.Name)
            {
                StringLocationMode = LocationModes.MiddleCenter;
            }
            else if (r.Name == rdbMiddleRight.Name)
            {
                StringLocationMode = LocationModes.MiddleRight;
            }
            else if (r.Name == rdbBottomCenter.Name)
            {
                StringLocationMode = LocationModes.BottomCenter;
            }
            else if (r.Name == rdbBottomLeft.Name)
            {
                StringLocationMode = LocationModes.BottomLeft;
            }
            else if (r.Name == rdbBottomRight.Name)
            {
                StringLocationMode = LocationModes.BottomRight;
            }
            PreviewLayer?.Dispose();
            PreviewLayer = new Bitmap(pibPreview.BackgroundImage.Width, pibPreview.BackgroundImage.Height, PixelFormat.Format32bppArgb);
            DrawWatermarkLayer(PreviewLayer);
            pibPreview.Image = PreviewLayer;
        }

        float stringRotateAngle;
        private void valueCircular1_ValueChanged(object sender, float e)
        {
            stringRotateAngle = valueCircular1.Value;
        }

        Color stringColor;
        private void colorPanel1_CurrentColor_Changed(object sender, Color e)
        {
            stringColor = colorPanel1.CurrentColor;
        }
    }
}
