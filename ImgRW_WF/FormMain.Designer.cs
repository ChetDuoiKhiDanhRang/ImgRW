
namespace ImgRW_WF
{
    partial class FormMain
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
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.colorPanel1 = new Controls_dotNetFrw.ColorPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbString = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).BeginInit();
            this.panelResize.SuspendLayout();
            this.panelWatermarkString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pibPreview
            // 
            this.pibPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pibPreview.BackColor = System.Drawing.SystemColors.Window;
            this.pibPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibPreview.Location = new System.Drawing.Point(579, 15);
            this.pibPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pibPreview.Name = "pibPreview";
            this.pibPreview.Size = new System.Drawing.Size(359, 228);
            this.pibPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibPreview.TabIndex = 0;
            this.pibPreview.TabStop = false;
            // 
            // lsvFiles
            // 
            this.lsvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvFiles.FullRowSelect = true;
            this.lsvFiles.GridLines = true;
            this.lsvFiles.HideSelection = false;
            this.lsvFiles.Location = new System.Drawing.Point(388, 15);
            this.lsvFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lsvFiles.Name = "lsvFiles";
            this.lsvFiles.Size = new System.Drawing.Size(183, 299);
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
            this.panelResize.Location = new System.Drawing.Point(13, 15);
            this.panelResize.Margin = new System.Windows.Forms.Padding(4);
            this.panelResize.Name = "panelResize";
            this.panelResize.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelResize.Size = new System.Drawing.Size(367, 132);
            this.panelResize.TabIndex = 2;
            this.panelResize.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "(pixel)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "(pixel)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 99);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 4;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 23);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "50";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "700";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "700";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(30, 100);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Theo tỉ lệ:";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(30, 71);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Theo chiều cao:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 42);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 21);
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
            this.ckbResize.Location = new System.Drawing.Point(20, 28);
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
            this.panelWatermarkString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWatermarkString.Controls.Add(this.numericUpDown2);
            this.panelWatermarkString.Controls.Add(this.numericUpDown1);
            this.panelWatermarkString.Controls.Add(this.checkBox2);
            this.panelWatermarkString.Controls.Add(this.colorPanel1);
            this.panelWatermarkString.Controls.Add(this.checkBox1);
            this.panelWatermarkString.Controls.Add(this.ckbItalic);
            this.panelWatermarkString.Controls.Add(this.ckbBold);
            this.panelWatermarkString.Controls.Add(this.comboBox1);
            this.panelWatermarkString.Controls.Add(this.label4);
            this.panelWatermarkString.Controls.Add(this.textBox4);
            this.panelWatermarkString.Location = new System.Drawing.Point(13, 155);
            this.panelWatermarkString.Margin = new System.Windows.Forms.Padding(4);
            this.panelWatermarkString.Name = "panelWatermarkString";
            this.panelWatermarkString.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelWatermarkString.Size = new System.Drawing.Size(367, 216);
            this.panelWatermarkString.TabIndex = 2;
            this.panelWatermarkString.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Location = new System.Drawing.Point(273, 69);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(273, 100);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(171, 100);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Khung viền:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // colorPanel1
            // 
            this.colorPanel1.AutoSize = true;
            this.colorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel1.CurrentColor = System.Drawing.Color.Empty;
            this.colorPanel1.CurrentColorHexString = null;
            this.colorPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPanel1.Location = new System.Drawing.Point(6, 66);
            this.colorPanel1.MinimumSize = new System.Drawing.Size(64, 64);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.colorPanel1.PanelStyle = Controls_dotNetFrw.PanelStyles.Panel;
            this.colorPanel1.RefObject = this.textBox4;
            this.colorPanel1.Size = new System.Drawing.Size(152, 141);
            this.colorPanel1.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 23);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Whatever";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(239, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(28, 28);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "U";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ckbItalic
            // 
            this.ckbItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbItalic.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(205, 66);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(28, 28);
            this.ckbItalic.TabIndex = 5;
            this.ckbItalic.Text = "I";
            this.ckbItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbItalic.UseVisualStyleBackColor = true;
            // 
            // ckbBold
            // 
            this.ckbBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbBold.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(171, 66);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(28, 28);
            this.ckbBold.TabIndex = 5;
            this.ckbBold.Text = "B";
            this.ckbBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbBold.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Font chữ:";
            // 
            // ckbString
            // 
            this.ckbString.AutoSize = true;
            this.ckbString.Checked = true;
            this.ckbString.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbString.Location = new System.Drawing.Point(20, 165);
            this.ckbString.Name = "ckbString";
            this.ckbString.Size = new System.Drawing.Size(155, 21);
            this.ckbString.TabIndex = 4;
            this.ckbString.Text = "Đặt dấu bằng chuỗi:";
            this.ckbString.UseVisualStyleBackColor = true;
            this.ckbString.CheckedChanged += new System.EventHandler(this.ckbString_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 559);
            this.Controls.Add(this.ckbString);
            this.Controls.Add(this.lsvFiles);
            this.Controls.Add(this.ckbResize);
            this.Controls.Add(this.pibPreview);
            this.Controls.Add(this.panelWatermarkString);
            this.Controls.Add(this.panelResize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).EndInit();
            this.panelResize.ResumeLayout(false);
            this.panelResize.PerformLayout();
            this.panelWatermarkString.ResumeLayout(false);
            this.panelWatermarkString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.CheckBox ckbString;
        private Controls_dotNetFrw.ColorPanel colorPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

