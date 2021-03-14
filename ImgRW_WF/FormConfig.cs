﻿using ImageModifier;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgRW_WF
{

    public partial class FormConfig : Form
    {
        public List<string> FontNames { get; set; }

        public event EventHandler<string> LanguageChanged;
        private string language = "vi";
        public string Language
        {
            get => language;
            set
            {
                language = value;
                LanguageChanged?.Invoke(this, language);
            }
        }

        Dictionary<string, ListViewItem> files;

        public FormConfig()
        {
            InitializeComponent();
            //PreviewLayer = new Bitmap(pibPreview.BackgroundImage.Width, pibPreview.BackgroundImage.Height, PixelFormat.Format32bppArgb);
            files = new Dictionary<string, ListViewItem>();
            PreviewLayer = new Bitmap(pibPreview.BackgroundImage.Width, pibPreview.BackgroundImage.Height, PixelFormat.Format32bppArgb);
        }

        private void InitialEvents()
        {
            //Resize
            this.ckbResize.CheckedChanged += new System.EventHandler(this.ckbResize_CheckedChanged);
            this.radFixHeight.CheckedChanged += new System.EventHandler(this.radResizeMode_CheckedChanged);
            this.radFixWidth.CheckedChanged += new System.EventHandler(this.radResizeMode_CheckedChanged);
            this.radScale.CheckedChanged += new System.EventHandler(this.radResizeMode_CheckedChanged);

            //String-----------------------------------------------------------------------------------
            this.ckbString.CheckedChanged += new System.EventHandler(this.ckbString_CheckedChanged);

            this.txbWString.TextChanged += new System.EventHandler(this.txbWString_TextChanged);

            ckbBold.CheckedChanged += ckbFontStyle_Changed;
            ckbItalic.CheckedChanged += ckbFontStyle_Changed;
            ckbUnderline.CheckedChanged += ckbFontStyle_Changed;

            vccString.ValueChanged += VccString_ValueChanged;

            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);

            this.nudWSLocationY.ValueChanged += new System.EventHandler(this.nudWSLocation_ValueChanged);
            this.nudWSLocationX.ValueChanged += new System.EventHandler(this.nudWSLocation_ValueChanged);


            this.ckbFrame.CheckedChanged += new System.EventHandler(this.ckbFrame_CheckedChanged);
            this.nudFrameLineWidth.ValueChanged += new System.EventHandler(this.nudFrameLineWidth_ValueChanged);

            this.rdbWSLocation.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbTopLeft.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbTopCenter.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbTopRight.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbMiddleLeft.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbMiddleCenter.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbMiddleRight.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbBottomLeft.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbBottomCenter.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);
            this.rdbBottomRight.CheckedChanged += new System.EventHandler(this.rdbStingLocationModes_CheckedChanged);

            this.colorPanel1.CurrentColor_Changed += new System.EventHandler<System.Drawing.Color>(this.colorPanel1_CurrentColor_Changed);


            //images-------------------------------------------------------------------------------------------------------------------
            this.ckbWatermarkImage.CheckedChanged += new System.EventHandler(this.ckbWatermarkImage_CheckedChanged);
            this.lsvFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvFiles_KeyDown);
            rdbWILocation.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWITopLeft.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWITopCenter.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWITopRight.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWIMiddleLeft.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWIMiddleCenter.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWIMiddleRight.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWIBottomLeft.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWIBottomCenter.CheckedChanged += rdbWILocation_CheckChanged;
            rdbWIBottomRight.CheckedChanged += rdbWILocation_CheckChanged;

            vldImageOptical.ValueChanged += VldImageOptical_ValueChanged;
            vccImage.ValueChanged += VccImage_ValueChanged;
            nudWIX.ValueChanged += nudWILocation_ValueChanged;
        }

        private void LoadSettings()
        {

            var x = Properties.Settings.Default;

            outputPath = x.outputPath;
            txbOutputPath.Text = x.outputPath;

            outputFormat = x.outputFormat;
            cmbOutputFormat.SelectedIndex = x.outputFormat;

            //Resize
            ckbResize.Checked = x.resize;
            panelResize.Enabled = ckbResize.Checked;
            resizeImages = x.resize;

            switch (x.resizeMode)
            {
                case ResizeModes.FixWidth:
                    radFixWidth.Checked = true;
                    txbFixWidth.Text = x.resizeValue.ToString("0");
                    break;
                case ResizeModes.FixHeight:
                    radFixHeight.Checked = true;
                    txbFixHeight.Text = x.resizeValue.ToString("0");
                    break;
                case ResizeModes.Scale:
                    radScale.Checked = true;
                    txbFixHeight.Text = x.resizeValue.ToString("0");
                    break;
                default:
                    break;
            }
            resizeMode = x.resizeMode;
            resizeValue = x.resizeValue;

            //Watermark string
            ckbString.Checked = x.drawString;
            drawString = x.drawString;
            panelWatermarkString.Enabled = ckbString.Checked;
            content = txbWString.Text = x.content;
            cmbFont.SelectedIndex = 0;
            foreach (var item in cmbFont.Items)
            {
                if ((string)item == x.fontName)
                {
                    cmbFont.SelectedItem = item;

                    break;
                }
            }
            ckbBold.Checked = x.fontStyleBold;
            ckbItalic.Checked = x.fontStyleItalic;
            ckbUnderline.Checked = x.fontStyleUnderline;
            nudFontSize.Value = x.fontSize;
            GenerateFont();

            ckbFrame.Checked = x.frameString;
            drawStringFrame = x.frameString;
            nudFrameLineWidth.Value = x.frameLineWidth;
            frameLineWidth = (float)x.frameLineWidth;

            nudWSLocationX.Value = x.stringLocationX;
            stringLocationX = (float)x.stringLocationX;
            nudWSLocationY.Value = x.stringLocationY;
            stringLocationY = (float)x.stringLocationY;


            colorPanel1.CurrentColorHexString = x.stringColor;
            stringColor = x.stringColor;

            stringRotateAngle = vccString.Value = x.stringRotateAngle;

            stringLocationMode = x.imageLocationMode;
            switch (x.stringLocationMode)
            {
                case LocationModes.Custom:
                    rdbWSLocation.Checked = true;
                    break;
                case LocationModes.TopLeft:
                    rdbTopLeft.Checked = true;
                    break;
                case LocationModes.TopCenter:
                    rdbTopCenter.Checked = true;
                    break;
                case LocationModes.TopRight:
                    rdbTopRight.Checked = true;
                    break;
                case LocationModes.MiddleLeft:
                    rdbMiddleLeft.Checked = true;
                    break;
                case LocationModes.MiddleCenter:
                    rdbMiddleCenter.Checked = true;
                    break;
                case LocationModes.MiddleRight:
                    rdbMiddleRight.Checked = true;
                    break;
                case LocationModes.BottomLeft:
                    rdbBottomLeft.Checked = true;
                    break;
                case LocationModes.BottomCenter:
                    rdbBottomCenter.Checked = true;
                    break;
                case LocationModes.BottomRight:
                    rdbBottomRight.Checked = true;
                    break;
                default:
                    break;
            }

            nudWSLocationX.Value = x.stringLocationX;
            nudWSLocationY.Value = x.stringLocationY;
            nudWSLocationX.Enabled = nudWSLocationY.Enabled = rdbWSLocation.Checked;

            //Watermark image
            ckbWatermarkImage.Checked = x.drawImage;
            drawImage = x.drawImage;
            panelWatermarkImage.Enabled = ckbWatermarkImage.Checked;

            imagePath = x.imagePath;
            if (File.Exists(imagePath))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open))
                {
                    pibWatermarkImage.BackgroundImage = Image.FromStream(fs);
                }
            }

            nudWIX.Value = x.imageLocationX;
            imageLocationX = (float)x.imageLocationX;
            nudWIY.Value = x.imageLocationY;
            imageLocationY = (float)x.imageLocationY;

            imageOptical = x.imageOptical;
            vldImageOptical.Value = x.imageOptical;

            imageLocationMode = x.imageLocationMode;

            switch (x.imageLocationMode)
            {
                case LocationModes.Custom:
                    rdbWILocation.Checked = true;
                    nudWSLocationX.Enabled = nudWSLocationY.Enabled = rdbWILocation.Checked;
                    break;
                case LocationModes.TopLeft:
                    rdbWITopLeft.Checked = true;
                    break;
                case LocationModes.TopCenter:
                    rdbWITopCenter.Checked = true;
                    break;
                case LocationModes.TopRight:
                    rdbWITopRight.Checked = true;
                    break;
                case LocationModes.MiddleLeft:
                    rdbWIMiddleLeft.Checked = true;
                    break;
                case LocationModes.MiddleCenter:
                    rdbWIMiddleCenter.Checked = true;
                    break;
                case LocationModes.MiddleRight:
                    rdbWIMiddleRight.Checked = true;
                    break;
                case LocationModes.BottomLeft:
                    rdbWIBottomLeft.Checked = true;
                    break;
                case LocationModes.BottomCenter:
                    rdbWIBottomCenter.Checked = true;
                    break;
                case LocationModes.BottomRight:
                    rdbWIBottomRight.Checked = true;
                    break;
                default:
                    break;
            }
            nudWIX.Enabled = nudWIY.Enabled = rdbWILocation.Checked;

            imageRotateAngle = x.imageRotateAngle;
            vccImage.Value = x.imageRotateAngle;
        }

        private void SaveSettings()
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            cmbFont.Invoke((Action)(() =>
            {
                FontNames = (new InstalledFontCollection()).Families.Select(f => f.Name).ToList();
                FontNames.Sort();
                cmbFont.DataSource = FontNames;
            }));
            LoadSettings();
            InitialEvents();
            RedrawPreview();
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
                                li.SubItems.Add(i.HorizontalResolution.ToString("0") + "/" + i.VerticalResolution.ToString("0") + "(dpi)");
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

        #region FIELDS===============================================================================================
        Bitmap PreviewLayer;
        string outputPath;
        byte outputFormat;

        //Resize images or not
        bool resizeImages;
        float resizeValue;
        private ResizeModes resizeMode;


        //Watermark string
        string content;
        bool drawString;
        LocationModes stringLocationMode;
        float stringLocationX;
        float stringLocationY;
        string fontName;
        float fontSize;

        FontStyle wsFontStyle;
        bool drawStringFrame;
        float frameLineWidth;
        float stringRotateAngle;
        string stringColor;


        //Watermark image------------------------------------------------------------------
        LocationModes imageLocationMode;
        float imageLocationX;
        float imageLocationY;
        float imageRotateAngle;
        float imageOptical;
        string imagePath;
        bool drawImage;
        Bitmap imageWatermark;
        #endregion

        #region WATERMARK STRING EVENTS============================================================================================
        //Changed font style
        private void ckbFontStyle_Changed(object sender, EventArgs e)
        {
            GenerateFont();
            RedrawPreview();
        }

        //Draw Watermark String or not
        private void ckbString_CheckedChanged(object sender, EventArgs e)
        {
            panelWatermarkString.Enabled = ckbString.Checked;
            drawString = ckbString.Checked;
            RedrawPreview();
        }

        //string custom location
        private void nudWSLocation_ValueChanged(object sender, EventArgs e)
        {
            stringLocationX = (float)nudWSLocationX.Value;
            stringLocationY = (float)nudWSLocationY.Value;
            RedrawPreview();
        }

        //changed font
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFont.SelectedIndex < 0) return;

            FontFamily fm = new FontFamily((string)cmbFont.SelectedItem);
            ckbBold.Enabled = fm.IsStyleAvailable(FontStyle.Bold);
            ckbItalic.Enabled = fm.IsStyleAvailable(FontStyle.Italic);
            ckbUnderline.Enabled = fm.IsStyleAvailable(FontStyle.Underline);
            GenerateFont();
            RedrawPreview();
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            GenerateFont();
            RedrawPreview();
        }

        //Generate font and style from UI controls
        private Font GenerateFont()
        {
            fontName = (string)cmbFont.SelectedItem;
            fontSize = (float)nudFontSize.Value;

            var bold = (ckbBold.Enabled & ckbBold.Checked) ? 1 : 0;
            var italic = (ckbItalic.Enabled & ckbItalic.Checked) ? 2 : 0;
            var underline = (ckbUnderline.Enabled & ckbUnderline.Checked) ? 4 : 0;
            wsFontStyle = (FontStyle)(bold | italic | underline);

            return new Font(fontName, fontSize, wsFontStyle);
        }

        //String content
        private void txbWString_TextChanged(object sender, EventArgs e)
        {
            if (txbWString.Text.Length == 0) return;
            content = txbWString.Text;
            RedrawPreview();
        }

        //Frame around string
        private void ckbFrame_CheckedChanged(object sender, EventArgs e)
        {
            drawStringFrame = ckbFrame.Checked;
            RedrawPreview();
        }

        private void nudFrameLineWidth_ValueChanged(object sender, EventArgs e)
        {
            frameLineWidth = (float)nudFrameLineWidth.Value;
            RedrawPreview();
        }

        //String watermark locations
        private void rdbStingLocationModes_CheckedChanged(object sender, EventArgs e)
        {
            var r = (RadioButton)sender;
            if (r.Checked == false) return;
            if (r.Name == rdbWSLocation.Name)
            {
                nudWSLocationX.Enabled = nudWSLocationY.Enabled = rdbWSLocation.Checked;
                stringLocationMode = LocationModes.Custom;
            }
            else if (r.Name == rdbTopLeft.Name)
            {
                stringLocationMode = LocationModes.TopLeft;
            }
            else if (r.Name == rdbTopCenter.Name)
            {
                stringLocationMode = LocationModes.TopCenter;
            }
            else if (r.Name == rdbTopRight.Name)
            {
                stringLocationMode = LocationModes.TopRight;
            }
            else if (r.Name == rdbMiddleLeft.Name)
            {
                stringLocationMode = LocationModes.MiddleLeft;
            }
            else if (r.Name == rdbMiddleCenter.Name)
            {
                stringLocationMode = LocationModes.MiddleCenter;
            }
            else if (r.Name == rdbMiddleRight.Name)
            {
                stringLocationMode = LocationModes.MiddleRight;
            }
            else if (r.Name == rdbBottomCenter.Name)
            {
                stringLocationMode = LocationModes.BottomCenter;
            }
            else if (r.Name == rdbBottomLeft.Name)
            {
                stringLocationMode = LocationModes.BottomLeft;
            }
            else if (r.Name == rdbBottomRight.Name)
            {
                stringLocationMode = LocationModes.BottomRight;
            }
            RedrawPreview();
        }

        //String watermark rotation angle
        private void VccString_ValueChanged(object sender, float e)
        {
            stringRotateAngle = vccString.Value;
            RedrawPreview();
        }

        //String watermark color
        private void colorPanel1_CurrentColor_Changed(object sender, Color e)
        {
            stringColor = colorPanel1.CurrentColorHexString;
            RedrawPreview();
        }
        #endregion

        #region WATERMARK IMAGE EVENTS================================================================================

        //Draw Watermark Image or not
        private void ckbWatermarkImage_CheckedChanged(object sender, EventArgs e)
        {
            panelWatermarkImage.Enabled = ckbWatermarkImage.Checked;
            drawImage = ckbWatermarkImage.Checked;
            RedrawPreview();
        }

        //change image watermark
        private void pibWatermarkImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (pibWatermarkImage.BackgroundImage == null) return;
            imageWatermark?.Dispose();
            imageWatermark = pibWatermarkImage.BackgroundImage.Clone() as Bitmap;
            RedrawPreview();
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
                    Bitmap background = new Bitmap(Image.FromStream(fs));
                    background.SetResolution(96, 96);
                    pibWatermarkImage.BackgroundImage?.Dispose();
                    pibWatermarkImage.BackgroundImage = background;
                }
            }
            ofd.Dispose();
        }

        //image location
        private void nudWILocation_ValueChanged(object sender, EventArgs e)
        {
            imageLocationX = (float)nudWIX.Value;
            imageLocationY = (float)nudWIY.Value;
            RedrawPreview();
        }

        //image location mode
        private void rdbWILocation_CheckChanged(object sender, EventArgs e)
        {
            var r = (RadioButton)sender;
            if (r.Name == rdbWILocation.Name)
            {
                imageLocationMode = LocationModes.Custom;
            }
            else if (r.Name == rdbWITopLeft.Name)
            {
                imageLocationMode = LocationModes.TopLeft;
            }
            else if (r.Name == rdbWITopCenter.Name)
            {
                imageLocationMode = LocationModes.TopCenter;
            }
            else if (r.Name == rdbWITopRight.Name)
            {
                imageLocationMode = LocationModes.TopRight;
            }
            else if (r.Name == rdbWIMiddleLeft.Name)
            {
                imageLocationMode = LocationModes.MiddleLeft;
            }
            else if (r.Name == rdbWIMiddleCenter.Name)
            {
                imageLocationMode = LocationModes.MiddleCenter;
            }
            else if (r.Name == rdbWIMiddleRight.Name)
            {
                imageLocationMode = LocationModes.MiddleRight;
            }
            else if (r.Name == rdbWIBottomLeft.Name)
            {
                imageLocationMode = LocationModes.BottomLeft;
            }
            else if (r.Name == rdbWIBottomCenter.Name)
            {
                imageLocationMode = LocationModes.BottomCenter;
            }
            else if (r.Name == rdbWIBottomRight.Name)
            {
                imageLocationMode = LocationModes.BottomRight;
            }

            nudWIX.Enabled = nudWIY.Enabled = rdbWILocation.Checked;

            RedrawPreview();
        }

        //image Optical
        private void VldImageOptical_ValueChanged(object sender, float e)
        {
            imageOptical = vldImageOptical.Value;
            RedrawPreview();
        }

        //rotate image
        private void VccImage_ValueChanged(object sender, float e)
        {
            imageRotateAngle = vccImage.Value;
            RedrawPreview();
        }
        #endregion

        #region RESIZES EVENTS=============================================================================================
        private void ckbResize_CheckedChanged(object sender, EventArgs e)
        {
            panelResize.Enabled = ckbResize.Checked;
            resizeImages = ckbResize.Checked;
        }

        private void radResizeMode_CheckedChanged(object sender, EventArgs e)
        {
            var ob = (RadioButton)sender;
            if (!ob.Checked) return;
            if (ob.Name == radFixHeight.Name)
            {
                resizeMode = ResizeModes.FixHeight;
            }
            else if (ob.Name == radFixWidth.Name)
            {
                resizeMode = ResizeModes.FixWidth;
            }
            else if (ob.Name == radScale.Name)
            {
                resizeMode = ResizeModes.Scale;
            }

        }
        #endregion

        #region DRAW AND OTHERS METHODS ===================================================================================

        private void pibPreview_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (pibPreview.BackgroundImage == null) return;
            if (nudWSLocationX.Value > pibPreview.BackgroundImage.Width)
            {
                nudWSLocationX.Value = pibPreview.BackgroundImage.Width / 2;
            }
            nudWSLocationX.Maximum = pibPreview.BackgroundImage.Width;

            if (nudWSLocationY.Value > pibPreview.BackgroundImage.Height)
            {
                nudWSLocationY.Value = pibPreview.BackgroundImage.Height / 2;
            }
            nudWSLocationY.Maximum = pibPreview.BackgroundImage.Height;

            RedrawPreview();
        }


        void RedrawPreview()
        {
            PreviewLayer?.Dispose();
            PreviewLayer = new Bitmap(pibPreview.BackgroundImage.Width, pibPreview.BackgroundImage.Height, PixelFormat.Format32bppArgb);
            //PreviewLayer.SetResolution(96F, 96F);
            DrawWatermarkLayer(PreviewLayer);
            pibPreview.Image = PreviewLayer;
        }

        private void DrawWatermarkLayer(Bitmap previewLayer)
        {
            if (drawImage && imageWatermark != null)
            {
                DrawImage(previewLayer, imageWatermark);
            }
            if (drawString)
            {
                DrawString(previewLayer);
            }
        }

        private void DrawImage(Bitmap imageLayer, Bitmap imgWatermark)
        {
            currentIndex++; //just for Tasks when process image list
            if (imgWatermark == null) return;
            using (Graphics graph = Graphics.FromImage(imageLayer))
            {
                //graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                //graph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                //graph.TextRenderingHint = TextRenderingHint.AntiAlias;
                var size = imgWatermark.Size;
                PointF location;
                switch (imageLocationMode)
                {
                    case LocationModes.Custom:
                        location = new PointF(imageLocationX, imageLocationY);
                        break;
                    case LocationModes.TopLeft:
                        location = new PointF(0, 0);
                        break;
                    case LocationModes.TopCenter:
                        location = new PointF((imageLayer.Width - size.Width) / 2, 0);
                        break;
                    case LocationModes.TopRight:
                        location = new PointF((imageLayer.Width - size.Width), 0);
                        break;
                    case LocationModes.MiddleLeft:
                        location = new PointF(0, (imageLayer.Height - size.Height) / 2);
                        break;
                    case LocationModes.MiddleCenter:
                        location = new PointF((imageLayer.Width - size.Width) / 2, (imageLayer.Height - size.Height) / 2);
                        break;
                    case LocationModes.MiddleRight:
                        location = new PointF((imageLayer.Width - size.Width), (imageLayer.Height - size.Height) / 2);
                        break;
                    case LocationModes.BottomLeft:
                        location = new PointF(0, (imageLayer.Height - size.Height));
                        break;
                    case LocationModes.BottomCenter:
                        location = new PointF((imageLayer.Width - size.Width) / 2, (imageLayer.Height - size.Height));
                        break;
                    case LocationModes.BottomRight:
                        location = new PointF((imageLayer.Width - size.Width), (imageLayer.Height - size.Height));
                        break;
                    default:
                        location = new PointF(0, 0);
                        break;
                }

                using (ImageAttributes ia = new ImageAttributes())
                {
                    ia.SetColorMatrix(new ColorMatrix() { Matrix33 = imageOptical });

                    graph.TranslateTransform(location.X, location.Y);
                    graph.RotateTransform(0 - imageRotateAngle);

                    graph.DrawImage(imgWatermark, new Rectangle(0, 0, size.Width, size.Height), 0, 0, size.Width, size.Height, GraphicsUnit.Pixel, ia);
                }
            }
        }

        private void DrawString(Bitmap previewLayer)
        {
            if (previewLayer == null) return;

            Graphics graph = Graphics.FromImage(previewLayer);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graph.TextRenderingHint = TextRenderingHint.AntiAlias;
            Font drawFont = new Font(fontName, fontSize, wsFontStyle);
            var size = graph.MeasureString(content, drawFont);
            PointF location;
            switch (stringLocationMode)
            {
                case LocationModes.Custom:
                    location = new PointF(stringLocationX, stringLocationY);
                    break;
                case LocationModes.TopLeft:
                    location = new PointF((drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        (drawStringFrame ? (float)(frameLineWidth / 2) : 0));
                    break;
                case LocationModes.TopCenter:
                    location = new PointF((previewLayer.Width - size.Width) / 2,
                        drawStringFrame ? (float)(frameLineWidth / 2) : 0);
                    break;
                case LocationModes.TopRight:
                    location = new PointF((previewLayer.Width - size.Width) - (drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        ckbFrame.Checked ? (float)(frameLineWidth / 2) : 0);
                    break;
                case LocationModes.MiddleLeft:
                    location = new PointF((drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        (previewLayer.Height - size.Height) / 2);
                    break;
                case LocationModes.MiddleCenter:
                    location = new PointF((previewLayer.Width - size.Width) / 2, (previewLayer.Height - size.Height) / 2);
                    break;
                case LocationModes.MiddleRight:
                    location = new PointF((previewLayer.Width - size.Width) - (drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        (previewLayer.Height - size.Height) / 2);
                    break;
                case LocationModes.BottomLeft:
                    location = new PointF((drawStringFrame ? (float)(frameLineWidth / 2) : 0),
                        (previewLayer.Height - size.Height) - (drawStringFrame ? (float)frameLineWidth / 2 : 0));
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
            //graph.FillRectangle(Brushes.Black, 0, 0, 256, 256); //test

            using (Brush b = new SolidBrush(ColorTranslator.FromHtml(stringColor)))
            {
                graph.DrawString(content, drawFont, b, 0, 0);
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
        #endregion

        //preview select image
        private void lsvFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = lsvFiles.GetItemAt(e.X, e.Y);
            if (item == null) return;
            string filePath = (string)item.Tag;
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    Image img = Image.FromStream(fs);
                    Bitmap tmp = new Bitmap(img);
                    tmp.SetResolution(96F, 96F);
                    Bitmap background;
                    if (resizeImages)
                    {
                        background = ResizeBitmap(tmp, resizeMode, resizeValue);
                    }
                    else
                    {
                        background = ResizeBitmap(tmp, ResizeModes.Scale, 100);
                    }
                    pibPreview.BackgroundImage?.Dispose();
                    pibPreview.BackgroundImage = background;

                    tmp.Dispose();
                    img.Dispose();
                }
            }
            else
            {
                string content;
                if (Language == "vi")
                {
                    content = "Tập tin không tồn tại!";
                }
                else
                {
                    content = "File not existed!";
                }
                MessageBox.Show(content, "!!!", MessageBoxButtons.OK);
            }

        }

        //resize a bitmap
        private Bitmap ResizeBitmap(Bitmap tmp, ResizeModes resizeMode, float resizeValue)
        {
            var originalSize = tmp.Size;
            Size newSize = originalSize;
            switch (resizeMode)
            {
                case ResizeModes.FixWidth:
                    newSize = new Size((int)resizeValue, (int)(originalSize.Height * resizeValue / originalSize.Width));
                    break;
                case ResizeModes.FixHeight:
                    newSize = new Size((int)(originalSize.Width * resizeValue / originalSize.Height), (int)resizeValue);
                    break;
                case ResizeModes.Scale:
                    newSize = new Size((int)(originalSize.Width * resizeValue / 100), (int)(originalSize.Height * resizeValue / 100));
                    break;
                default:
                    break;
            }
            Bitmap result = Resizer.ResizeImage(tmp, newSize);

            return result;
        }

        //select output path
        private void pibOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.MyComputer
            };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txbOutputPath.Text = fbd.SelectedPath;
                outputPath = fbd.SelectedPath;
            }
            fbd.Dispose();
        }

        //Generate utput file name
        string GenerateOutputFileName(string originalFilePath, string outputPath, byte outputFormat)
        {
            string outputName;
            string outputExtension = "";
            outputName = Path.GetFileNameWithoutExtension(originalFilePath);

            if (outputFormat == 0)
            {
                outputExtension = Path.GetExtension(originalFilePath);
            }
            else if (outputFormat == 1)
            {
                outputExtension = ".png";
            }
            else if (outputFormat == 2)
            {
                outputExtension = ".jpg";
            }
            else if (outputFormat == 3)
            {
                outputExtension = ".bmp";
            }
            int count = 0;
            while (File.Exists(outputPath + "\\" + outputName + "_" + (count > 0 ? count.ToString() : "") + outputExtension))
            {
                count++;
            }

            return (outputPath + "\\" + outputName + "_" + (count > 0 ? count.ToString() : "") + outputExtension);
        }


        //select output format
        private void cmbOutputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputFormat = (byte)cmbOutputFormat.SelectedIndex;
        }

        Bitmap[] imgWMs;
        long currentIndex = 0;
        void HandleImage(object input)
        {
            string inputFile = (string)input;
            string threadID = Thread.CurrentThread.ManagedThreadId.ToString();
            try
            {
                txbStatus.BeginInvoke((Action)(() =>
                {
                    txbStatus.AppendText("\r\n[Thread start, managed ID: " + threadID + " ] ");
                    txbStatus.AppendText("\r\n[PRC] " + inputFile);
                }));

                Image img;
                Bitmap bmp;
                using (FileStream fs = new FileStream(inputFile, FileMode.Open))
                {
                    img = Image.FromStream(fs);
                    bmp = new Bitmap(img);
                }
                Bitmap result;

                //Resize images
                if (resizeImages)
                {
                    result = ResizeBitmap(bmp, resizeMode, resizeValue);
                }
                else
                {
                    result = ResizeBitmap(bmp, ResizeModes.Scale, 100);
                }
                txbStatus.BeginInvoke((Action)(() =>
                {
                    txbStatus.AppendText("\r\n[RSZ] " + input);
                }));

                //Draw string watermark
                if (drawString)
                {
                    DrawString(result);
                    txbStatus.BeginInvoke((Action)(() =>
                    {
                        txbStatus.AppendText("\r\n[DST] " + input + ".[v]");
                    }));
                }

                //draw image watermark
                if (drawImage && imgWMs[currentIndex] != null)
                {
                    DrawImage(result, imgWMs[currentIndex]);
                    txbStatus.BeginInvoke((Action)(() =>
                    {
                        txbStatus.AppendText("\r\n[DIM] " + input);
                    }));
                }

                string outputFile = GenerateOutputFileName(inputFile, outputPath, outputFormat);
                ImageFormat saveFormat = img.RawFormat;
                if (outputFormat == 0)
                {
                    saveFormat = img.RawFormat;
                }
                else if (outputFormat == 1)
                {
                    saveFormat = ImageFormat.Png;
                }
                else if (outputFormat == 2)
                {
                    saveFormat = ImageFormat.Jpeg;
                }
                else if (outputFormat == 3)
                {
                    saveFormat = ImageFormat.Bmp;
                }

                bmp.Dispose();
                img.Dispose();
                result.Save(outputFile, saveFormat);
                txbStatus.BeginInvoke((Action)(() =>
                {
                    txbStatus.AppendText("\r\n[Thread end, managed ID: " + threadID + "]");
                    txbStatus.AppendText("\r\n[SAV] " + input);
                }));
                valueSlider2.BeginInvoke((Action)(() => { valueSlider2.Value += 1; }));
            }
            catch (Exception ex)
            {
                txbStatus.Invoke((Action)(() =>
                {
                    txbStatus.Text += "\n[ERR Thrd.ID: " + threadID + "]..." + ex.Message;
                }));
            }
        }

        private void pibRun_Click(object sender, EventArgs e)
        {
            txbStatus.Text = "";

            if (!Directory.Exists(outputPath))
            {
                txbOutputPath.ForeColor = Color.DarkRed;
                txbStatus.ForeColor = Color.DarkRed;
                txbStatus.Text = language == "vi" ? "Thư mục ra không tồn tại!" : "Output path no exist";
                return;
            }
            txbOutputPath.ForeColor = DefaultForeColor;
            txbStatus.ForeColor = Color.White;

            if (files.Count == 0) return;

            //Generate images list for watermark
            imgWMs = new Bitmap[files.Count];
            if (drawImage && imageWatermark != null)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    imgWMs[i] = imageWatermark.Clone() as Bitmap;

                }
            }

            valueSlider2.MinValue = valueSlider2.Value = 0;
            valueSlider2.MaxValue = files.Count;
            currentIndex = 0;
            var inputs = files.Keys.ToArray();
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < files.Count; i++)
            {
                Thread t = new Thread(HandleImage);
                t.IsBackground = true;
                t.Name = "thread handle image: " + i;
                threads.Add(t);
                t.Start(inputs[i]);
            }

            foreach (Thread item in threads)
            {
                item.Join();
            }

            for (int i = 0; i < files.Count; i++)
            {
                imgWMs[i]?.Dispose();
            }
            txbStatus.AppendText("\r\n=======================================");


        }
    }
}
