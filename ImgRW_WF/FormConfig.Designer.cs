﻿namespace ImgRW_WF
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pibPreview = new System.Windows.Forms.PictureBox();
            this.lsvFiles = new System.Windows.Forms.ListView();
            this.panelResize = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ckbResize = new System.Windows.Forms.CheckBox();
            this.panelWatermarkString = new System.Windows.Forms.Panel();
            this.txbWString = new System.Windows.Forms.TextBox();
            this.rdbWSLocation = new System.Windows.Forms.RadioButton();
            this.rdbBottomCenter = new System.Windows.Forms.RadioButton();
            this.rdbBottomRight = new System.Windows.Forms.RadioButton();
            this.rdbMiddleCenter = new System.Windows.Forms.RadioButton();
            this.rdbMiddleRight = new System.Windows.Forms.RadioButton();
            this.rdbBottomLeft = new System.Windows.Forms.RadioButton();
            this.rdbTopCenter = new System.Windows.Forms.RadioButton();
            this.rdbMiddleLeft = new System.Windows.Forms.RadioButton();
            this.rdbTopRight = new System.Windows.Forms.RadioButton();
            this.rdbTopLeft = new System.Windows.Forms.RadioButton();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.nudWSLocationY = new System.Windows.Forms.NumericUpDown();
            this.nudWSLocationX = new System.Windows.Forms.NumericUpDown();
            this.nudFrameSize = new System.Windows.Forms.NumericUpDown();
            this.ckbFrame = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbString = new System.Windows.Forms.CheckBox();
            this.panelWatermarkImage = new System.Windows.Forms.Panel();
            this.valueSlider1 = new Controls_dotNetFrw.ValueSlider();
            this.pibWatermarkImage = new System.Windows.Forms.PictureBox();
            this.rdbWILocation = new System.Windows.Forms.RadioButton();
            this.rdbWIBottomCenter = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbWIBottomRight = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rdbWIMiddleCenter = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.rdbWIMiddleRight = new System.Windows.Forms.RadioButton();
            this.rdbWITopLeft = new System.Windows.Forms.RadioButton();
            this.rdbWIBottomLeft = new System.Windows.Forms.RadioButton();
            this.rdbWITopRight = new System.Windows.Forms.RadioButton();
            this.rdbWITopCenter = new System.Windows.Forms.RadioButton();
            this.rdbWIMiddleLeft = new System.Windows.Forms.RadioButton();
            this.lblWITransparent = new System.Windows.Forms.Label();
            this.ckbWatermarkImage = new System.Windows.Forms.CheckBox();
            this.colorPanel1 = new Controls_dotNetFrw.ColorPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).BeginInit();
            this.panelResize.SuspendLayout();
            this.panelWatermarkString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWSLocationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWSLocationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameSize)).BeginInit();
            this.panelWatermarkImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibWatermarkImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pibPreview
            // 
            this.pibPreview.BackColor = System.Drawing.SystemColors.Window;
            this.pibPreview.BackgroundImage = global::ImgRW_WF.Properties.Resources.WindowsXPBliss_mod1;
            this.pibPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pibPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibPreview.Location = new System.Drawing.Point(244, 12);
            this.pibPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pibPreview.Name = "pibPreview";
            this.pibPreview.Size = new System.Drawing.Size(428, 300);
            this.pibPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibPreview.TabIndex = 0;
            this.pibPreview.TabStop = false;
            // 
            // lsvFiles
            // 
            this.lsvFiles.AllowDrop = true;
            this.lsvFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvFiles.FullRowSelect = true;
            this.lsvFiles.GridLines = true;
            this.lsvFiles.HideSelection = false;
            this.lsvFiles.Location = new System.Drawing.Point(11, 144);
            this.lsvFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lsvFiles.Name = "lsvFiles";
            this.lsvFiles.Size = new System.Drawing.Size(225, 238);
            this.lsvFiles.TabIndex = 1;
            this.lsvFiles.UseCompatibleStateImageBehavior = false;
            // 
            // panelResize
            // 
            this.panelResize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResize.Controls.Add(this.label3);
            this.panelResize.Controls.Add(this.label2);
            this.panelResize.Controls.Add(this.label1);
            this.panelResize.Controls.Add(this.textBox3);
            this.panelResize.Controls.Add(this.textBox2);
            this.panelResize.Controls.Add(this.textBox1);
            this.panelResize.Controls.Add(this.radioButton3);
            this.panelResize.Controls.Add(this.radioButton2);
            this.panelResize.Controls.Add(this.radioButton1);
            this.panelResize.Location = new System.Drawing.Point(11, 12);
            this.panelResize.Margin = new System.Windows.Forms.Padding(4);
            this.panelResize.Name = "panelResize";
            this.panelResize.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelResize.Size = new System.Drawing.Size(225, 124);
            this.panelResize.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "(pixel)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "(pixel)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 93);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 4;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "50";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "700";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "700";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 94);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 19);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Theo tỉ lệ:";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 67);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Theo chiều cao:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 39);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Theo chiều rộng:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ckbResize
            // 
            this.ckbResize.AutoSize = true;
            this.ckbResize.Checked = true;
            this.ckbResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbResize.Location = new System.Drawing.Point(17, 22);
            this.ckbResize.Margin = new System.Windows.Forms.Padding(4);
            this.ckbResize.Name = "ckbResize";
            this.ckbResize.Size = new System.Drawing.Size(158, 21);
            this.ckbResize.TabIndex = 3;
            this.ckbResize.Text = "Đặt lại kích thước:";
            this.ckbResize.UseVisualStyleBackColor = true;
            this.ckbResize.CheckedChanged += new System.EventHandler(this.ckbResize_CheckedChanged);
            // 
            // panelWatermarkString
            // 
            this.panelWatermarkString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWatermarkString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWatermarkString.Controls.Add(this.colorPanel1);
            this.panelWatermarkString.Controls.Add(this.rdbWSLocation);
            this.panelWatermarkString.Controls.Add(this.rdbBottomCenter);
            this.panelWatermarkString.Controls.Add(this.rdbBottomRight);
            this.panelWatermarkString.Controls.Add(this.rdbMiddleCenter);
            this.panelWatermarkString.Controls.Add(this.rdbMiddleRight);
            this.panelWatermarkString.Controls.Add(this.rdbBottomLeft);
            this.panelWatermarkString.Controls.Add(this.rdbTopCenter);
            this.panelWatermarkString.Controls.Add(this.rdbMiddleLeft);
            this.panelWatermarkString.Controls.Add(this.rdbTopRight);
            this.panelWatermarkString.Controls.Add(this.rdbTopLeft);
            this.panelWatermarkString.Controls.Add(this.nudFontSize);
            this.panelWatermarkString.Controls.Add(this.nudWSLocationY);
            this.panelWatermarkString.Controls.Add(this.nudWSLocationX);
            this.panelWatermarkString.Controls.Add(this.nudFrameSize);
            this.panelWatermarkString.Controls.Add(this.ckbFrame);
            this.panelWatermarkString.Controls.Add(this.checkBox1);
            this.panelWatermarkString.Controls.Add(this.ckbItalic);
            this.panelWatermarkString.Controls.Add(this.ckbBold);
            this.panelWatermarkString.Controls.Add(this.cmbFont);
            this.panelWatermarkString.Controls.Add(this.label6);
            this.panelWatermarkString.Controls.Add(this.label4);
            this.panelWatermarkString.Controls.Add(this.txbWString);
            this.panelWatermarkString.Location = new System.Drawing.Point(680, 12);
            this.panelWatermarkString.Margin = new System.Windows.Forms.Padding(4);
            this.panelWatermarkString.Name = "panelWatermarkString";
            this.panelWatermarkString.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelWatermarkString.Size = new System.Drawing.Size(321, 203);
            this.panelWatermarkString.TabIndex = 2;
            // 
            // txbWString
            // 
            this.txbWString.Location = new System.Drawing.Point(163, 7);
            this.txbWString.Name = "txbWString";
            this.txbWString.Size = new System.Drawing.Size(148, 21);
            this.txbWString.TabIndex = 1;
            this.txbWString.Text = "Whatever";
            this.txbWString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbWSLocation
            // 
            this.rdbWSLocation.AutoSize = true;
            this.rdbWSLocation.Location = new System.Drawing.Point(164, 121);
            this.rdbWSLocation.Name = "rdbWSLocation";
            this.rdbWSLocation.Size = new System.Drawing.Size(36, 19);
            this.rdbWSLocation.TabIndex = 10;
            this.rdbWSLocation.TabStop = true;
            this.rdbWSLocation.Text = "X:";
            this.rdbWSLocation.UseVisualStyleBackColor = true;
            this.rdbWSLocation.CheckedChanged += new System.EventHandler(this.rdbLocation_CheckedChanged);
            // 
            // rdbBottomCenter
            // 
            this.rdbBottomCenter.AutoSize = true;
            this.rdbBottomCenter.Location = new System.Drawing.Point(230, 184);
            this.rdbBottomCenter.Name = "rdbBottomCenter";
            this.rdbBottomCenter.Size = new System.Drawing.Size(14, 13);
            this.rdbBottomCenter.TabIndex = 10;
            this.rdbBottomCenter.TabStop = true;
            this.rdbBottomCenter.UseVisualStyleBackColor = true;
            // 
            // rdbBottomRight
            // 
            this.rdbBottomRight.AutoSize = true;
            this.rdbBottomRight.Location = new System.Drawing.Point(297, 184);
            this.rdbBottomRight.Name = "rdbBottomRight";
            this.rdbBottomRight.Size = new System.Drawing.Size(14, 13);
            this.rdbBottomRight.TabIndex = 10;
            this.rdbBottomRight.TabStop = true;
            this.rdbBottomRight.UseVisualStyleBackColor = true;
            // 
            // rdbMiddleCenter
            // 
            this.rdbMiddleCenter.AutoSize = true;
            this.rdbMiddleCenter.Location = new System.Drawing.Point(230, 166);
            this.rdbMiddleCenter.Name = "rdbMiddleCenter";
            this.rdbMiddleCenter.Size = new System.Drawing.Size(14, 13);
            this.rdbMiddleCenter.TabIndex = 10;
            this.rdbMiddleCenter.TabStop = true;
            this.rdbMiddleCenter.UseVisualStyleBackColor = true;
            // 
            // rdbMiddleRight
            // 
            this.rdbMiddleRight.AutoSize = true;
            this.rdbMiddleRight.Location = new System.Drawing.Point(297, 166);
            this.rdbMiddleRight.Name = "rdbMiddleRight";
            this.rdbMiddleRight.Size = new System.Drawing.Size(14, 13);
            this.rdbMiddleRight.TabIndex = 10;
            this.rdbMiddleRight.TabStop = true;
            this.rdbMiddleRight.UseVisualStyleBackColor = true;
            // 
            // rdbBottomLeft
            // 
            this.rdbBottomLeft.AutoSize = true;
            this.rdbBottomLeft.Location = new System.Drawing.Point(164, 184);
            this.rdbBottomLeft.Name = "rdbBottomLeft";
            this.rdbBottomLeft.Size = new System.Drawing.Size(14, 13);
            this.rdbBottomLeft.TabIndex = 10;
            this.rdbBottomLeft.TabStop = true;
            this.rdbBottomLeft.UseVisualStyleBackColor = true;
            // 
            // rdbTopCenter
            // 
            this.rdbTopCenter.AutoSize = true;
            this.rdbTopCenter.Location = new System.Drawing.Point(230, 148);
            this.rdbTopCenter.Name = "rdbTopCenter";
            this.rdbTopCenter.Size = new System.Drawing.Size(14, 13);
            this.rdbTopCenter.TabIndex = 10;
            this.rdbTopCenter.TabStop = true;
            this.rdbTopCenter.UseVisualStyleBackColor = true;
            // 
            // rdbMiddleLeft
            // 
            this.rdbMiddleLeft.AutoSize = true;
            this.rdbMiddleLeft.Location = new System.Drawing.Point(164, 166);
            this.rdbMiddleLeft.Name = "rdbMiddleLeft";
            this.rdbMiddleLeft.Size = new System.Drawing.Size(14, 13);
            this.rdbMiddleLeft.TabIndex = 10;
            this.rdbMiddleLeft.TabStop = true;
            this.rdbMiddleLeft.UseVisualStyleBackColor = true;
            // 
            // rdbTopRight
            // 
            this.rdbTopRight.AutoSize = true;
            this.rdbTopRight.Location = new System.Drawing.Point(297, 148);
            this.rdbTopRight.Name = "rdbTopRight";
            this.rdbTopRight.Size = new System.Drawing.Size(14, 13);
            this.rdbTopRight.TabIndex = 10;
            this.rdbTopRight.TabStop = true;
            this.rdbTopRight.UseVisualStyleBackColor = true;
            // 
            // rdbTopLeft
            // 
            this.rdbTopLeft.AutoSize = true;
            this.rdbTopLeft.Location = new System.Drawing.Point(164, 148);
            this.rdbTopLeft.Name = "rdbTopLeft";
            this.rdbTopLeft.Size = new System.Drawing.Size(14, 13);
            this.rdbTopLeft.TabIndex = 10;
            this.rdbTopLeft.TabStop = true;
            this.rdbTopLeft.UseVisualStyleBackColor = true;
            // 
            // nudFontSize
            // 
            this.nudFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFontSize.Location = new System.Drawing.Point(269, 65);
            this.nudFontSize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudFontSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(42, 21);
            this.nudFontSize.TabIndex = 8;
            this.nudFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFontSize.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // nudWSLocationY
            // 
            this.nudWSLocationY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWSLocationY.Location = new System.Drawing.Point(269, 121);
            this.nudWSLocationY.Name = "nudWSLocationY";
            this.nudWSLocationY.Size = new System.Drawing.Size(42, 21);
            this.nudWSLocationY.TabIndex = 8;
            this.nudWSLocationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWSLocationY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudWSLocationX
            // 
            this.nudWSLocationX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWSLocationX.Location = new System.Drawing.Point(203, 121);
            this.nudWSLocationX.Name = "nudWSLocationX";
            this.nudWSLocationX.Size = new System.Drawing.Size(42, 21);
            this.nudWSLocationX.TabIndex = 8;
            this.nudWSLocationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWSLocationX.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudFrameSize
            // 
            this.nudFrameSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFrameSize.Location = new System.Drawing.Point(269, 94);
            this.nudFrameSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudFrameSize.Name = "nudFrameSize";
            this.nudFrameSize.Size = new System.Drawing.Size(42, 21);
            this.nudFrameSize.TabIndex = 8;
            this.nudFrameSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFrameSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ckbFrame
            // 
            this.ckbFrame.AutoSize = true;
            this.ckbFrame.Location = new System.Drawing.Point(164, 94);
            this.ckbFrame.Name = "ckbFrame";
            this.ckbFrame.Size = new System.Drawing.Size(90, 19);
            this.ckbFrame.TabIndex = 7;
            this.ckbFrame.Text = "Khung viền:";
            this.ckbFrame.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(232, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(24, 26);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "U";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ckbItalic
            // 
            this.ckbItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbItalic.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(198, 62);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(24, 26);
            this.ckbItalic.TabIndex = 5;
            this.ckbItalic.Text = "I";
            this.ckbItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbItalic.UseVisualStyleBackColor = true;
            // 
            // ckbBold
            // 
            this.ckbBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbBold.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(164, 62);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(24, 26);
            this.ckbBold.TabIndex = 5;
            this.ckbBold.Text = "B";
            this.ckbBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbBold.UseVisualStyleBackColor = true;
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.IntegralHeight = false;
            this.cmbFont.Location = new System.Drawing.Point(163, 34);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(148, 23);
            this.cmbFont.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Font chữ:";
            // 
            // ckbString
            // 
            this.ckbString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbString.AutoSize = true;
            this.ckbString.Checked = true;
            this.ckbString.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbString.Location = new System.Drawing.Point(687, 22);
            this.ckbString.Name = "ckbString";
            this.ckbString.Size = new System.Drawing.Size(155, 19);
            this.ckbString.TabIndex = 4;
            this.ckbString.Text = "Đặt dấu bằng chuỗi:";
            this.ckbString.UseVisualStyleBackColor = true;
            this.ckbString.CheckedChanged += new System.EventHandler(this.ckbString_CheckedChanged);
            // 
            // panelWatermarkImage
            // 
            this.panelWatermarkImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWatermarkImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWatermarkImage.Controls.Add(this.valueSlider1);
            this.panelWatermarkImage.Controls.Add(this.pibWatermarkImage);
            this.panelWatermarkImage.Controls.Add(this.rdbWILocation);
            this.panelWatermarkImage.Controls.Add(this.rdbWIBottomCenter);
            this.panelWatermarkImage.Controls.Add(this.label5);
            this.panelWatermarkImage.Controls.Add(this.rdbWIBottomRight);
            this.panelWatermarkImage.Controls.Add(this.numericUpDown1);
            this.panelWatermarkImage.Controls.Add(this.rdbWIMiddleCenter);
            this.panelWatermarkImage.Controls.Add(this.numericUpDown2);
            this.panelWatermarkImage.Controls.Add(this.rdbWIMiddleRight);
            this.panelWatermarkImage.Controls.Add(this.rdbWITopLeft);
            this.panelWatermarkImage.Controls.Add(this.rdbWIBottomLeft);
            this.panelWatermarkImage.Controls.Add(this.rdbWITopRight);
            this.panelWatermarkImage.Controls.Add(this.rdbWITopCenter);
            this.panelWatermarkImage.Controls.Add(this.rdbWIMiddleLeft);
            this.panelWatermarkImage.Controls.Add(this.lblWITransparent);
            this.panelWatermarkImage.Location = new System.Drawing.Point(680, 222);
            this.panelWatermarkImage.Name = "panelWatermarkImage";
            this.panelWatermarkImage.Size = new System.Drawing.Size(321, 160);
            this.panelWatermarkImage.TabIndex = 5;
            // 
            // valueSlider1
            // 
            this.valueSlider1.Location = new System.Drawing.Point(80, 135);
            this.valueSlider1.MaxValue = 100F;
            this.valueSlider1.MinValue = 1F;
            this.valueSlider1.Name = "valueSlider1";
            this.valueSlider1.OffsetLines = false;
            this.valueSlider1.OffsetLinesColor = System.Drawing.Color.DarkGray;
            this.valueSlider1.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.valueSlider1.PointerSize = 6;
            this.valueSlider1.PointerStyle = Controls_dotNetFrw.PointerStyles.Dot;
            this.valueSlider1.Size = new System.Drawing.Size(228, 11);
            this.valueSlider1.Style = Controls_dotNetFrw.ValueSliderStyles.GradientLine;
            this.valueSlider1.TabIndex = 11;
            this.valueSlider1.Text = "valueSlider1";
            this.valueSlider1.Value = 85F;
            this.valueSlider1.ValueBackColor = System.Drawing.Color.LightGray;
            this.valueSlider1.ValueColor = System.Drawing.Color.DodgerBlue;
            this.valueSlider1.ValueSliderOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pibWatermarkImage
            // 
            this.pibWatermarkImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pibWatermarkImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibWatermarkImage.Location = new System.Drawing.Point(163, 8);
            this.pibWatermarkImage.Name = "pibWatermarkImage";
            this.pibWatermarkImage.Size = new System.Drawing.Size(146, 119);
            this.pibWatermarkImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibWatermarkImage.TabIndex = 0;
            this.pibWatermarkImage.TabStop = false;
            // 
            // rdbWILocation
            // 
            this.rdbWILocation.AutoSize = true;
            this.rdbWILocation.Location = new System.Drawing.Point(5, 33);
            this.rdbWILocation.Name = "rdbWILocation";
            this.rdbWILocation.Size = new System.Drawing.Size(36, 19);
            this.rdbWILocation.TabIndex = 10;
            this.rdbWILocation.TabStop = true;
            this.rdbWILocation.Text = "X:";
            this.rdbWILocation.UseVisualStyleBackColor = true;
            this.rdbWILocation.CheckedChanged += new System.EventHandler(this.rdbLocation_CheckedChanged);
            // 
            // rdbWIBottomCenter
            // 
            this.rdbWIBottomCenter.AutoSize = true;
            this.rdbWIBottomCenter.Location = new System.Drawing.Point(72, 105);
            this.rdbWIBottomCenter.Name = "rdbWIBottomCenter";
            this.rdbWIBottomCenter.Size = new System.Drawing.Size(14, 13);
            this.rdbWIBottomCenter.TabIndex = 10;
            this.rdbWIBottomCenter.TabStop = true;
            this.rdbWIBottomCenter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y:";
            // 
            // rdbWIBottomRight
            // 
            this.rdbWIBottomRight.AutoSize = true;
            this.rdbWIBottomRight.Location = new System.Drawing.Point(138, 105);
            this.rdbWIBottomRight.Name = "rdbWIBottomRight";
            this.rdbWIBottomRight.Size = new System.Drawing.Size(14, 13);
            this.rdbWIBottomRight.TabIndex = 10;
            this.rdbWIBottomRight.TabStop = true;
            this.rdbWIBottomRight.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(108, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 21);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // rdbWIMiddleCenter
            // 
            this.rdbWIMiddleCenter.AutoSize = true;
            this.rdbWIMiddleCenter.Location = new System.Drawing.Point(72, 87);
            this.rdbWIMiddleCenter.Name = "rdbWIMiddleCenter";
            this.rdbWIMiddleCenter.Size = new System.Drawing.Size(14, 13);
            this.rdbWIMiddleCenter.TabIndex = 10;
            this.rdbWIMiddleCenter.TabStop = true;
            this.rdbWIMiddleCenter.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Location = new System.Drawing.Point(43, 33);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 21);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // rdbWIMiddleRight
            // 
            this.rdbWIMiddleRight.AutoSize = true;
            this.rdbWIMiddleRight.Location = new System.Drawing.Point(138, 87);
            this.rdbWIMiddleRight.Name = "rdbWIMiddleRight";
            this.rdbWIMiddleRight.Size = new System.Drawing.Size(14, 13);
            this.rdbWIMiddleRight.TabIndex = 10;
            this.rdbWIMiddleRight.TabStop = true;
            this.rdbWIMiddleRight.UseVisualStyleBackColor = true;
            // 
            // rdbWITopLeft
            // 
            this.rdbWITopLeft.AutoSize = true;
            this.rdbWITopLeft.Location = new System.Drawing.Point(5, 69);
            this.rdbWITopLeft.Name = "rdbWITopLeft";
            this.rdbWITopLeft.Size = new System.Drawing.Size(14, 13);
            this.rdbWITopLeft.TabIndex = 10;
            this.rdbWITopLeft.TabStop = true;
            this.rdbWITopLeft.UseVisualStyleBackColor = true;
            // 
            // rdbWIBottomLeft
            // 
            this.rdbWIBottomLeft.AutoSize = true;
            this.rdbWIBottomLeft.Location = new System.Drawing.Point(5, 105);
            this.rdbWIBottomLeft.Name = "rdbWIBottomLeft";
            this.rdbWIBottomLeft.Size = new System.Drawing.Size(14, 13);
            this.rdbWIBottomLeft.TabIndex = 10;
            this.rdbWIBottomLeft.TabStop = true;
            this.rdbWIBottomLeft.UseVisualStyleBackColor = true;
            // 
            // rdbWITopRight
            // 
            this.rdbWITopRight.AutoSize = true;
            this.rdbWITopRight.Location = new System.Drawing.Point(138, 69);
            this.rdbWITopRight.Name = "rdbWITopRight";
            this.rdbWITopRight.Size = new System.Drawing.Size(14, 13);
            this.rdbWITopRight.TabIndex = 10;
            this.rdbWITopRight.TabStop = true;
            this.rdbWITopRight.UseVisualStyleBackColor = true;
            // 
            // rdbWITopCenter
            // 
            this.rdbWITopCenter.AutoSize = true;
            this.rdbWITopCenter.Location = new System.Drawing.Point(72, 69);
            this.rdbWITopCenter.Name = "rdbWITopCenter";
            this.rdbWITopCenter.Size = new System.Drawing.Size(14, 13);
            this.rdbWITopCenter.TabIndex = 10;
            this.rdbWITopCenter.TabStop = true;
            this.rdbWITopCenter.UseVisualStyleBackColor = true;
            // 
            // rdbWIMiddleLeft
            // 
            this.rdbWIMiddleLeft.AutoSize = true;
            this.rdbWIMiddleLeft.Location = new System.Drawing.Point(5, 87);
            this.rdbWIMiddleLeft.Name = "rdbWIMiddleLeft";
            this.rdbWIMiddleLeft.Size = new System.Drawing.Size(14, 13);
            this.rdbWIMiddleLeft.TabIndex = 10;
            this.rdbWIMiddleLeft.TabStop = true;
            this.rdbWIMiddleLeft.UseVisualStyleBackColor = true;
            // 
            // lblWITransparent
            // 
            this.lblWITransparent.AutoSize = true;
            this.lblWITransparent.Location = new System.Drawing.Point(4, 131);
            this.lblWITransparent.Name = "lblWITransparent";
            this.lblWITransparent.Size = new System.Drawing.Size(68, 15);
            this.lblWITransparent.TabIndex = 2;
            this.lblWITransparent.Text = "Trong suốt:";
            // 
            // ckbWatermarkImage
            // 
            this.ckbWatermarkImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbWatermarkImage.AutoSize = true;
            this.ckbWatermarkImage.Checked = true;
            this.ckbWatermarkImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbWatermarkImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWatermarkImage.Location = new System.Drawing.Point(688, 232);
            this.ckbWatermarkImage.Name = "ckbWatermarkImage";
            this.ckbWatermarkImage.Size = new System.Drawing.Size(144, 19);
            this.ckbWatermarkImage.TabIndex = 4;
            this.ckbWatermarkImage.Text = "Đặt dấu bằng ảnh:";
            this.ckbWatermarkImage.UseVisualStyleBackColor = true;
            this.ckbWatermarkImage.CheckedChanged += new System.EventHandler(this.ckbWatermarkImage_CheckedChanged);
            // 
            // colorPanel1
            // 
            this.colorPanel1.AutoSize = true;
            this.colorPanel1.CurrentColor = System.Drawing.Color.Cyan;
            this.colorPanel1.CurrentColorHexString = null;
            this.colorPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorPanel1.Location = new System.Drawing.Point(6, 62);
            this.colorPanel1.MinimumSize = new System.Drawing.Size(64, 64);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.colorPanel1.PanelStyle = Controls_dotNetFrw.PanelStyles.Wheel;
            this.colorPanel1.RefControl = null;
            this.colorPanel1.Size = new System.Drawing.Size(144, 130);
            this.colorPanel1.TabIndex = 6;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 650);
            this.Controls.Add(this.ckbWatermarkImage);
            this.Controls.Add(this.ckbString);
            this.Controls.Add(this.lsvFiles);
            this.Controls.Add(this.ckbResize);
            this.Controls.Add(this.panelWatermarkString);
            this.Controls.Add(this.panelResize);
            this.Controls.Add(this.pibPreview);
            this.Controls.Add(this.panelWatermarkImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConfig";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).EndInit();
            this.panelResize.ResumeLayout(false);
            this.panelResize.PerformLayout();
            this.panelWatermarkString.ResumeLayout(false);
            this.panelWatermarkString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWSLocationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWSLocationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameSize)).EndInit();
            this.panelWatermarkImage.ResumeLayout(false);
            this.panelWatermarkImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibWatermarkImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibPreview;
        private System.Windows.Forms.ListView lsvFiles;
        private System.Windows.Forms.Panel panelResize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbResize;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panelWatermarkString;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbWString;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.CheckBox ckbString;
        private System.Windows.Forms.NumericUpDown nudFrameSize;
        private System.Windows.Forms.CheckBox ckbFrame;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.RadioButton rdbWSLocation;
        private System.Windows.Forms.RadioButton rdbBottomCenter;
        private System.Windows.Forms.RadioButton rdbBottomRight;
        private System.Windows.Forms.RadioButton rdbMiddleCenter;
        private System.Windows.Forms.RadioButton rdbMiddleRight;
        private System.Windows.Forms.RadioButton rdbBottomLeft;
        private System.Windows.Forms.RadioButton rdbTopCenter;
        private System.Windows.Forms.RadioButton rdbMiddleLeft;
        private System.Windows.Forms.RadioButton rdbTopRight;
        private System.Windows.Forms.RadioButton rdbTopLeft;
        private System.Windows.Forms.NumericUpDown nudWSLocationY;
        private System.Windows.Forms.NumericUpDown nudWSLocationX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelWatermarkImage;
        private System.Windows.Forms.CheckBox ckbWatermarkImage;
        private System.Windows.Forms.PictureBox pibWatermarkImage;
        private System.Windows.Forms.RadioButton rdbWILocation;
        private System.Windows.Forms.RadioButton rdbWIBottomCenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbWIBottomRight;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rdbWIMiddleCenter;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton rdbWIMiddleRight;
        private System.Windows.Forms.RadioButton rdbWITopLeft;
        private System.Windows.Forms.RadioButton rdbWIBottomLeft;
        private System.Windows.Forms.RadioButton rdbWITopRight;
        private System.Windows.Forms.RadioButton rdbWITopCenter;
        private System.Windows.Forms.RadioButton rdbWIMiddleLeft;
        private Controls_dotNetFrw.ValueSlider valueSlider1;
        private System.Windows.Forms.Label lblWITransparent;
        private Controls_dotNetFrw.ColorPanel colorPanel1;
    }
}

