
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
            this.ckbResize = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ckbString = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
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
            this.pibPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lsvFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(367, 103);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbResize
            // 
            this.ckbResize.AutoSize = true;
            this.ckbResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbResize.Location = new System.Drawing.Point(13, 15);
            this.ckbResize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbResize.Name = "ckbResize";
            this.ckbResize.Size = new System.Drawing.Size(158, 21);
            this.ckbResize.TabIndex = 3;
            this.ckbResize.Text = "Đặt lại kích thước:";
            this.ckbResize.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 10);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Theo chiều rộng:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "700";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "(pixel)";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "(%)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.ckbItalic);
            this.panel2.Controls.Add(this.ckbBold);
            this.panel2.Controls.Add(this.ckbString);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(13, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(367, 281);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 23);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "012345678901234567890";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Font chữ:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 3;
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
            // ckbBold
            // 
            this.ckbBold.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(239, 155);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(88, 20);
            this.ckbBold.TabIndex = 5;
            this.ckbBold.Text = "In đậm";
            this.ckbBold.UseVisualStyleBackColor = true;
            // 
            // ckbItalic
            // 
            this.ckbItalic.AutoSize = true;
            this.ckbItalic.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(239, 181);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(88, 20);
            this.ckbItalic.TabIndex = 5;
            this.ckbItalic.Text = "In nghiêng";
            this.ckbItalic.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(239, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Gạch chân";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnColor.Location = new System.Drawing.Point(158, 40);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(28, 28);
            this.btnColor.TabIndex = 6;
            this.btnColor.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnColor;
    }
}

