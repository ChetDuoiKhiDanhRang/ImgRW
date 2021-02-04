
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorPanelString = new Controls_dotNetFrw.ColorPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.ckbString = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pibPreview
            // 
            this.pibPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pibPreview.BackColor = System.Drawing.SystemColors.Window;
            this.pibPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibPreview.Location = new System.Drawing.Point(763, 44);
            this.pibPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pibPreview.Name = "pibPreview";
            this.pibPreview.Size = new System.Drawing.Size(406, 357);
            this.pibPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibPreview.TabIndex = 0;
            this.pibPreview.TabStop = false;
            // 
            // lsvFiles
            // 
            this.lsvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvFiles.FullRowSelect = true;
            this.lsvFiles.GridLines = true;
            this.lsvFiles.HideSelection = false;
            this.lsvFiles.Location = new System.Drawing.Point(388, 44);
            this.lsvFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lsvFiles.Name = "lsvFiles";
            this.lsvFiles.Size = new System.Drawing.Size(367, 251);
            this.lsvFiles.TabIndex = 1;
            this.lsvFiles.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(367, 103);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "(pixel)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "(pixel)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 67);
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
            this.textBox2.Location = new System.Drawing.Point(187, 38);
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
            this.textBox1.Location = new System.Drawing.Point(187, 9);
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
            this.radioButton3.Location = new System.Drawing.Point(30, 68);
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
            this.radioButton2.Location = new System.Drawing.Point(30, 39);
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
            this.radioButton1.Location = new System.Drawing.Point(30, 10);
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
            this.ckbResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbResize.Location = new System.Drawing.Point(13, 15);
            this.ckbResize.Margin = new System.Windows.Forms.Padding(4);
            this.ckbResize.Name = "ckbResize";
            this.ckbResize.Size = new System.Drawing.Size(158, 21);
            this.ckbResize.TabIndex = 3;
            this.ckbResize.Text = "Đặt lại kích thước:";
            this.ckbResize.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.colorPanelString);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.ckbItalic);
            this.panel2.Controls.Add(this.ckbBold);
            this.panel2.Controls.Add(this.ckbString);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(13, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(367, 281);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPanelString
            // 
            this.colorPanelString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanelString.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorPanelString.Location = new System.Drawing.Point(10, 138);
            this.colorPanelString.Margin = new System.Windows.Forms.Padding(4);
            this.colorPanelString.MinimumSize = new System.Drawing.Size(85, 78);
            this.colorPanelString.Name = "colorPanelString";
            this.colorPanelString.Padding = new System.Windows.Forms.Padding(1);
            this.colorPanelString.Size = new System.Drawing.Size(233, 78);
            this.colorPanelString.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(327, 36);
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
            this.ckbItalic.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(293, 36);
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
            this.ckbBold.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(259, 36);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(28, 28);
            this.ckbBold.TabIndex = 5;
            this.ckbBold.Text = "B";
            this.ckbBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbBold.UseVisualStyleBackColor = true;
            // 
            // ckbString
            // 
            this.ckbString.AutoSize = true;
            this.ckbString.Location = new System.Drawing.Point(10, 9);
            this.ckbString.Name = "ckbString";
            this.ckbString.Size = new System.Drawing.Size(155, 21);
            this.ckbString.TabIndex = 4;
            this.ckbString.Text = "Đặt dấu bằng chuỗi:";
            this.ckbString.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Font chữ:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kích thước:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(171, 39);
            this.textBox5.MaxLength = 3;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 23);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "444";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvFiles);
            this.Controls.Add(this.ckbResize);
            this.Controls.Add(this.pibPreview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibPreview;
        private System.Windows.Forms.ListView lsvFiles;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.CheckBox ckbString;
        private Controls_dotNetFrw.ColorPanel colorPanelString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
    }
}

