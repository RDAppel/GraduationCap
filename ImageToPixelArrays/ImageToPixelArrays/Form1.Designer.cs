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
            this.rdoLinear = new System.Windows.Forms.RadioButton();
            this.rdoPixelData = new System.Windows.Forms.RadioButton();
            this.rdoGrid = new System.Windows.Forms.RadioButton();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cboZoom = new System.Windows.Forms.ComboBox();
            this.cboOutputFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.staMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.White;
            this.pbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage.Location = new System.Drawing.Point(12, 65);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(320, 320);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1018, 24);
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
            this.mnuFileSeperator1.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(191, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // txtImageData
            // 
            this.txtImageData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageData.Location = new System.Drawing.Point(338, 65);
            this.txtImageData.Multiline = true;
            this.txtImageData.Name = "txtImageData";
            this.txtImageData.ReadOnly = true;
            this.txtImageData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImageData.Size = new System.Drawing.Size(668, 320);
            this.txtImageData.TabIndex = 2;
            // 
            // staMain
            // 
            this.staMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staSize});
            this.staMain.Location = new System.Drawing.Point(0, 400);
            this.staMain.Name = "staMain";
            this.staMain.Size = new System.Drawing.Size(1018, 22);
            this.staMain.TabIndex = 3;
            this.staMain.Text = "statusStrip1";
            // 
            // staSize
            // 
            this.staSize.Name = "staSize";
            this.staSize.Size = new System.Drawing.Size(0, 17);
            // 
            // rdoLinear
            // 
            this.rdoLinear.AutoSize = true;
            this.rdoLinear.Checked = true;
            this.rdoLinear.Location = new System.Drawing.Point(605, 36);
            this.rdoLinear.Name = "rdoLinear";
            this.rdoLinear.Size = new System.Drawing.Size(81, 17);
            this.rdoLinear.TabIndex = 4;
            this.rdoLinear.TabStop = true;
            this.rdoLinear.Text = "Linear Array";
            this.rdoLinear.UseVisualStyleBackColor = true;
            this.rdoLinear.CheckedChanged += new System.EventHandler(this.rdoDisplay_CheckedChanged);
            // 
            // rdoPixelData
            // 
            this.rdoPixelData.AutoSize = true;
            this.rdoPixelData.Location = new System.Drawing.Point(697, 36);
            this.rdoPixelData.Name = "rdoPixelData";
            this.rdoPixelData.Size = new System.Drawing.Size(100, 17);
            this.rdoPixelData.TabIndex = 4;
            this.rdoPixelData.Text = "Pixel Data Array";
            this.rdoPixelData.UseVisualStyleBackColor = true;
            this.rdoPixelData.CheckedChanged += new System.EventHandler(this.rdoDisplay_CheckedChanged);
            // 
            // rdoGrid
            // 
            this.rdoGrid.AutoSize = true;
            this.rdoGrid.Location = new System.Drawing.Point(808, 36);
            this.rdoGrid.Name = "rdoGrid";
            this.rdoGrid.Size = new System.Drawing.Size(71, 17);
            this.rdoGrid.TabIndex = 4;
            this.rdoGrid.Text = "Grid Array";
            this.rdoGrid.UseVisualStyleBackColor = true;
            this.rdoGrid.CheckedChanged += new System.EventHandler(this.rdoDisplay_CheckedChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(931, 33);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy Text";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cboZoom
            // 
            this.cboZoom.FormattingEnabled = true;
            this.cboZoom.Location = new System.Drawing.Point(55, 35);
            this.cboZoom.Name = "cboZoom";
            this.cboZoom.Size = new System.Drawing.Size(78, 21);
            this.cboZoom.TabIndex = 6;
            // 
            // cboOutputFormat
            // 
            this.cboOutputFormat.FormattingEnabled = true;
            this.cboOutputFormat.Location = new System.Drawing.Point(430, 35);
            this.cboOutputFormat.Name = "cboOutputFormat";
            this.cboOutputFormat.Size = new System.Drawing.Size(156, 21);
            this.cboOutputFormat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zoom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Format: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOutputFormat);
            this.Controls.Add(this.cboZoom);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.rdoGrid);
            this.Controls.Add(this.rdoPixelData);
            this.Controls.Add(this.rdoLinear);
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
        private System.Windows.Forms.RadioButton rdoLinear;
        private System.Windows.Forms.RadioButton rdoPixelData;
        private System.Windows.Forms.RadioButton rdoGrid;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cboZoom;
        private System.Windows.Forms.ComboBox cboOutputFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

