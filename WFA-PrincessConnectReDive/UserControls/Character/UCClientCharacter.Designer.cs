namespace UserControls
{
    partial class UCClientCharacter
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
            this.panelClient = new System.Windows.Forms.Panel();
            this.panelMultiFolder = new System.Windows.Forms.Panel();
            this.PActiveMultiFolder = new System.Windows.Forms.Panel();
            this.btnFFAffiliation = new System.Windows.Forms.Button();
            this.panelSingleFolder = new System.Windows.Forms.Panel();
            this.PActiveSingleFolder = new System.Windows.Forms.Panel();
            this.btnGuild = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblActiveTask = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelClientTask = new System.Windows.Forms.Panel();
            this.panelClient.SuspendLayout();
            this.panelMultiFolder.SuspendLayout();
            this.panelSingleFolder.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panelClient.Controls.Add(this.panelMultiFolder);
            this.panelClient.Controls.Add(this.panelSingleFolder);
            this.panelClient.Controls.Add(this.panelTitle);
            this.panelClient.Controls.Add(this.panelHome);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(256, 680);
            this.panelClient.TabIndex = 1;
            // 
            // panelMultiFolder
            // 
            this.panelMultiFolder.Controls.Add(this.PActiveMultiFolder);
            this.panelMultiFolder.Controls.Add(this.btnFFAffiliation);
            this.panelMultiFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMultiFolder.Location = new System.Drawing.Point(0, 196);
            this.panelMultiFolder.Name = "panelMultiFolder";
            this.panelMultiFolder.Size = new System.Drawing.Size(256, 38);
            this.panelMultiFolder.TabIndex = 24;
            // 
            // PActiveMultiFolder
            // 
            this.PActiveMultiFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveMultiFolder.Location = new System.Drawing.Point(0, 0);
            this.PActiveMultiFolder.Name = "PActiveMultiFolder";
            this.PActiveMultiFolder.Size = new System.Drawing.Size(6, 35);
            this.PActiveMultiFolder.TabIndex = 15;
            // 
            // btnFFAffiliation
            // 
            this.btnFFAffiliation.FlatAppearance.BorderSize = 0;
            this.btnFFAffiliation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.btnFFAffiliation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.btnFFAffiliation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFFAffiliation.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFFAffiliation.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnFFAffiliation.Image = global::WFA_PrincessConnectReDive.Properties.Resources.play_24px;
            this.btnFFAffiliation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFFAffiliation.Location = new System.Drawing.Point(9, 0);
            this.btnFFAffiliation.Name = "btnFFAffiliation";
            this.btnFFAffiliation.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnFFAffiliation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFFAffiliation.Size = new System.Drawing.Size(244, 35);
            this.btnFFAffiliation.TabIndex = 16;
            this.btnFFAffiliation.Text = "          ไร้สังกัด";
            this.btnFFAffiliation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFFAffiliation.UseVisualStyleBackColor = true;
            this.btnFFAffiliation.Click += new System.EventHandler(this.btnMulFolder_Click);
            // 
            // panelSingleFolder
            // 
            this.panelSingleFolder.Controls.Add(this.PActiveSingleFolder);
            this.panelSingleFolder.Controls.Add(this.btnGuild);
            this.panelSingleFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSingleFolder.Location = new System.Drawing.Point(0, 158);
            this.panelSingleFolder.Name = "panelSingleFolder";
            this.panelSingleFolder.Size = new System.Drawing.Size(256, 38);
            this.panelSingleFolder.TabIndex = 22;
            // 
            // PActiveSingleFolder
            // 
            this.PActiveSingleFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.PActiveSingleFolder.Location = new System.Drawing.Point(0, 0);
            this.PActiveSingleFolder.Name = "PActiveSingleFolder";
            this.PActiveSingleFolder.Size = new System.Drawing.Size(6, 35);
            this.PActiveSingleFolder.TabIndex = 15;
            // 
            // btnGuild
            // 
            this.btnGuild.FlatAppearance.BorderSize = 0;
            this.btnGuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.btnGuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.btnGuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuild.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuild.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuild.Image = global::WFA_PrincessConnectReDive.Properties.Resources.play_24px;
            this.btnGuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuild.Location = new System.Drawing.Point(9, 0);
            this.btnGuild.Name = "btnGuild";
            this.btnGuild.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnGuild.Size = new System.Drawing.Size(244, 35);
            this.btnGuild.TabIndex = 0;
            this.btnGuild.Text = "          กิลด์";
            this.btnGuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuild.UseVisualStyleBackColor = true;
            this.btnGuild.Click += new System.EventHandler(this.btnSingleFolder_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblActiveTask);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 38);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(256, 120);
            this.panelTitle.TabIndex = 21;
            // 
            // lblActiveTask
            // 
            this.lblActiveTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActiveTask.AutoSize = true;
            this.lblActiveTask.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblActiveTask.Location = new System.Drawing.Point(23, 38);
            this.lblActiveTask.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblActiveTask.Name = "lblActiveTask";
            this.lblActiveTask.Size = new System.Drawing.Size(60, 19);
            this.lblActiveTask.TabIndex = 3;
            this.lblActiveTask.Text = "ตัวละคร";
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(256, 38);
            this.panelHome.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnHome.Image = global::WFA_PrincessConnectReDive.Properties.Resources.home_32px2;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(256, 35);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelClientTask
            // 
            this.panelClientTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            this.panelClientTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientTask.Location = new System.Drawing.Point(256, 0);
            this.panelClientTask.Name = "panelClientTask";
            this.panelClientTask.Size = new System.Drawing.Size(994, 680);
            this.panelClientTask.TabIndex = 2;
            // 
            // UCClientCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelClientTask);
            this.Controls.Add(this.panelClient);
            this.Name = "UCClientCharacter";
            this.Size = new System.Drawing.Size(1250, 680);
            this.panelClient.ResumeLayout(false);
            this.panelMultiFolder.ResumeLayout(false);
            this.panelSingleFolder.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Panel PActiveSingleFolder;
        private System.Windows.Forms.Button btnGuild;
        private System.Windows.Forms.Label lblActiveTask;
        private System.Windows.Forms.Panel panelClientTask;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelSingleFolder;
        private System.Windows.Forms.Panel panelMultiFolder;
        private System.Windows.Forms.Panel PActiveMultiFolder;
        private System.Windows.Forms.Button btnFFAffiliation;
        private System.Windows.Forms.Button btnHome;
    }
}
