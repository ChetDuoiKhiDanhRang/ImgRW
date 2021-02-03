
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
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pibPreview
            // 
            this.pibPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pibPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibPreview.Location = new System.Drawing.Point(13, 13);
            this.pibPreview.Name = "pibPreview";
            this.pibPreview.Size = new System.Drawing.Size(524, 425);
            this.pibPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibPreview.TabIndex = 0;
            this.pibPreview.TabStop = false;
            // 
            // lsvFiles
            // 
            this.lsvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFiles.FullRowSelect = true;
            this.lsvFiles.GridLines = true;
            this.lsvFiles.HideSelection = false;
            this.lsvFiles.Location = new System.Drawing.Point(543, 13);
            this.lsvFiles.Name = "lsvFiles";
            this.lsvFiles.Size = new System.Drawing.Size(421, 425);
            this.lsvFiles.TabIndex = 1;
            this.lsvFiles.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 644);
            this.Controls.Add(this.lsvFiles);
            this.Controls.Add(this.pibPreview);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pibPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibPreview;
        private System.Windows.Forms.ListView lsvFiles;
    }
}

