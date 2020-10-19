namespace WFA.PlugIn
{
    partial class WaitFormGif
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
            this.picGifLoading = new System.Windows.Forms.PictureBox();
            this.picGifCharc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGifCharc)).BeginInit();
            this.SuspendLayout();
            // 
            // picGifLoading
            // 
            this.picGifLoading.BackgroundImage = global::WFA_PlugIn.Properties.Resources.TextLoading;
            this.picGifLoading.Image = global::WFA_PlugIn.Properties.Resources.TextLoading;
            this.picGifLoading.Location = new System.Drawing.Point(23, 114);
            this.picGifLoading.Name = "picGifLoading";
            this.picGifLoading.Size = new System.Drawing.Size(156, 127);
            this.picGifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGifLoading.TabIndex = 1;
            this.picGifLoading.TabStop = false;
            // 
            // picGifCharc
            // 
            this.picGifCharc.BackColor = System.Drawing.Color.Black;
            this.picGifCharc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGifCharc.Image = global::WFA_PlugIn.Properties.Resources.CharcLoading;
            this.picGifCharc.Location = new System.Drawing.Point(23, 12);
            this.picGifCharc.Name = "picGifCharc";
            this.picGifCharc.Size = new System.Drawing.Size(156, 129);
            this.picGifCharc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGifCharc.TabIndex = 2;
            this.picGifCharc.TabStop = false;
            // 
            // WFA_WaitFormGif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.ControlBox = false;
            this.Controls.Add(this.picGifCharc);
            this.Controls.Add(this.picGifLoading);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WFA_WaitFormGif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.picGifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGifCharc)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox picGifLoading;
        private System.Windows.Forms.PictureBox picGifCharc;
    }
}