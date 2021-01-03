namespace TestCam
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCameras = new System.Windows.Forms.ListBox();
            this.txtbRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbAutosave = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbRefreshRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera:";
            // 
            // btnCloseSettings
            // 
            this.btnCloseSettings.Location = new System.Drawing.Point(407, 56);
            this.btnCloseSettings.Name = "btnCloseSettings";
            this.btnCloseSettings.Size = new System.Drawing.Size(75, 23);
            this.btnCloseSettings.TabIndex = 6;
            this.btnCloseSettings.Text = "Confirm";
            this.btnCloseSettings.UseVisualStyleBackColor = true;
            this.btnCloseSettings.Click += new System.EventHandler(this.btnCloseSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbCameras
            // 
            this.lbCameras.FormattingEnabled = true;
            this.lbCameras.Location = new System.Drawing.Point(163, 58);
            this.lbCameras.Name = "lbCameras";
            this.lbCameras.Size = new System.Drawing.Size(222, 95);
            this.lbCameras.TabIndex = 8;
            // 
            // txtbRefreshRate
            // 
            this.txtbRefreshRate.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtbRefreshRate.Location = new System.Drawing.Point(185, 30);
            this.txtbRefreshRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtbRefreshRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtbRefreshRate.Name = "txtbRefreshRate";
            this.txtbRefreshRate.Size = new System.Drawing.Size(49, 20);
            this.txtbRefreshRate.TabIndex = 9;
            this.txtbRefreshRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Refresh rate";
            // 
            // cbAutosave
            // 
            this.cbAutosave.AutoSize = true;
            this.cbAutosave.Location = new System.Drawing.Point(407, 85);
            this.cbAutosave.Name = "cbAutosave";
            this.cbAutosave.Size = new System.Drawing.Size(74, 17);
            this.cbAutosave.TabIndex = 11;
            this.cbAutosave.Text = "Auto save";
            this.cbAutosave.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 165);
            this.Controls.Add(this.cbAutosave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbRefreshRate);
            this.Controls.Add(this.lbCameras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseSettings);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbRefreshRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ListBox lbCameras;
        private System.Windows.Forms.NumericUpDown txtbRefreshRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox cbAutosave;
    }
}