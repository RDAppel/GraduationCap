namespace ImageToPixelArrays
{
    partial class Form1
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
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtImageData = new System.Windows.Forms.TextBox();
            this.staMain = new System.Windows.Forms.StatusStrip();
            this.staSize = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.staMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImage.BackColor = System.Drawing.Color.White;
            this.pbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage.Location = new System.Drawing.Point(12, 36);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(300, 300);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(994, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenImage,
            this.mnuFileSeperator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpenImage
            // 
            this.mnuFileOpenImage.Name = "mnuFileOpenImage";
            this.mnuFileOpenImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpenImage.Size = new System.Drawing.Size(191, 22);
            this.mnuFileOpenImage.Text = "&Open Image...";
            this.mnuFileOpenImage.Click += new System.EventHandler(this.mnuFileOpenImage_Click);
            // 
            // mnuFileSeperator1
            // 
            this.mnuFileSeperator1.Name = "mnuFileSeperator1";
            this.mnuFileSeperator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // txtImageData
            // 
            this.txtImageData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageData.Location = new System.Drawing.Point(325, 36);
            this.txtImageData.Multiline = true;
            this.txtImageData.Name = "txtImageData";
            this.txtImageData.ReadOnly = true;
            this.txtImageData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImageData.Size = new System.Drawing.Size(657, 300);
            this.txtImageData.TabIndex = 2;
            // 
            // staMain
            // 
            this.staMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staSize});
            this.staMain.Location = new System.Drawing.Point(0, 351);
            this.staMain.Name = "staMain";
            this.staMain.Size = new System.Drawing.Size(994, 22);
            this.staMain.TabIndex = 3;
            this.staMain.Text = "statusStrip1";
            // 
            // staSize
            // 
            this.staSize.Name = "staSize";
            this.staSize.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 373);
            this.Controls.Add(this.staMain);
            this.Controls.Add(this.txtImageData);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.Text = "Bitmap to Pixel Arrays";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.staMain.ResumeLayout(false);
            this.staMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenImage;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeperator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.TextBox txtImageData;
        private System.Windows.Forms.StatusStrip staMain;
        private System.Windows.Forms.ToolStripStatusLabel staSize;
    }
}

