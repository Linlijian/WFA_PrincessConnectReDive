namespace Character
{
    partial class UCCharacterList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ddlGuildList = new System.Windows.Forms.ComboBox();
            this.lblGuildNane = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.ddlCharacterList = new System.Windows.Forms.ComboBox();
            this.picboxCharacter = new System.Windows.Forms.PictureBox();
            this.picboxCharacterBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCharacterBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlGuildList
            // 
            this.ddlGuildList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ddlGuildList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGuildList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlGuildList.Font = new System.Drawing.Font("Itim", 12F);
            this.ddlGuildList.ForeColor = System.Drawing.Color.DarkCyan;
            this.ddlGuildList.FormattingEnabled = true;
            this.ddlGuildList.Location = new System.Drawing.Point(85, 90);
            this.ddlGuildList.Name = "ddlGuildList";
            this.ddlGuildList.Size = new System.Drawing.Size(284, 27);
            this.ddlGuildList.TabIndex = 2;
            // 
            // lblGuildNane
            // 
            this.lblGuildNane.AutoSize = true;
            this.lblGuildNane.Font = new System.Drawing.Font("Itim", 16F);
            this.lblGuildNane.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblGuildNane.Location = new System.Drawing.Point(80, 50);
            this.lblGuildNane.Name = "lblGuildNane";
            this.lblGuildNane.Size = new System.Drawing.Size(50, 27);
            this.lblGuildNane.TabIndex = 3;
            this.lblGuildNane.Text = "กิลด์";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Itim", 16F);
            this.lblCharacter.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCharacter.Location = new System.Drawing.Point(80, 130);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(81, 27);
            this.lblCharacter.TabIndex = 4;
            this.lblCharacter.Text = "ตัวละคร";
            // 
            // ddlCharacterList
            // 
            this.ddlCharacterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ddlCharacterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCharacterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlCharacterList.Font = new System.Drawing.Font("Itim", 12F);
            this.ddlCharacterList.ForeColor = System.Drawing.Color.DarkCyan;
            this.ddlCharacterList.FormattingEnabled = true;
            this.ddlCharacterList.Location = new System.Drawing.Point(85, 173);
            this.ddlCharacterList.Name = "ddlCharacterList";
            this.ddlCharacterList.Size = new System.Drawing.Size(284, 27);
            this.ddlCharacterList.TabIndex = 5;
            // 
            // picboxCharacter
            // 
            this.picboxCharacter.Location = new System.Drawing.Point(484, 90);
            this.picboxCharacter.Name = "picboxCharacter";
            this.picboxCharacter.Size = new System.Drawing.Size(476, 598);
            this.picboxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxCharacter.TabIndex = 6;
            this.picboxCharacter.TabStop = false;
            // 
            // picboxCharacterBtn
            // 
            this.picboxCharacterBtn.Location = new System.Drawing.Point(778, 31);
            this.picboxCharacterBtn.Name = "picboxCharacterBtn";
            this.picboxCharacterBtn.Size = new System.Drawing.Size(182, 53);
            this.picboxCharacterBtn.TabIndex = 7;
            this.picboxCharacterBtn.TabStop = false;
            // 
            // UCCharacterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.picboxCharacterBtn);
            this.Controls.Add(this.picboxCharacter);
            this.Controls.Add(this.ddlCharacterList);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblGuildNane);
            this.Controls.Add(this.ddlGuildList);
            this.Font = new System.Drawing.Font("Itim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCCharacterList";
            this.Size = new System.Drawing.Size(994, 720);
            this.Load += new System.EventHandler(this.UCCharacterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCharacterBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlGuildList;
        private System.Windows.Forms.Label lblGuildNane;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.ComboBox ddlCharacterList;
        private System.Windows.Forms.PictureBox picboxCharacter;
        private System.Windows.Forms.PictureBox picboxCharacterBtn;
    }
}
