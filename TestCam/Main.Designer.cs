namespace TestCam
{
    partial class Appolon
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appolon));
            this.pbox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.DataGridLeerlingen = new System.Windows.Forms.DataGridView();
            this.btnPower = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voornaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reden = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(12, 70);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(344, 263);
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(500, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(545, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(545, 53);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 36);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(48, 538);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(61, 13);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "lblComment";
            this.lblComment.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(48, 515);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "lblResult";
            this.lblResult.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(63, 14);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 45);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 11;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.pictureBox3_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // DataGridLeerlingen
            // 
            this.DataGridLeerlingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLeerlingen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naam,
            this.Voornaam,
            this.Klas,
            this.Reden,
            this.ID});
            this.DataGridLeerlingen.Location = new System.Drawing.Point(276, 339);
            this.DataGridLeerlingen.Name = "DataGridLeerlingen";
            this.DataGridLeerlingen.Size = new System.Drawing.Size(494, 235);
            this.DataGridLeerlingen.TabIndex = 13;
            // 
            // btnPower
            // 
            this.btnPower.Image = ((System.Drawing.Image)(resources.GetObject("btnPower.Image")));
            this.btnPower.Location = new System.Drawing.Point(12, 14);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(45, 45);
            this.btnPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPower.TabIndex = 14;
            this.btnPower.TabStop = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            this.btnPower.MouseEnter += new System.EventHandler(this.btnPower_MouseEnter);
            this.btnPower.MouseLeave += new System.EventHandler(this.btnPower_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(114, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 15;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(165, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(45, 45);
            this.btnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoad.TabIndex = 16;
            this.btnLoad.TabStop = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.MouseEnter += new System.EventHandler(this.btnLoad_MouseEnter);
            this.btnLoad.MouseLeave += new System.EventHandler(this.btnLoad_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripProgressBar,
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripProgressBar
            // 
            this.StripProgressBar.Name = "StripProgressBar";
            this.StripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lblError
            // 
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            // 
            // Voornaam
            // 
            this.Voornaam.HeaderText = "Voornaam";
            this.Voornaam.Name = "Voornaam";
            // 
            // Klas
            // 
            this.Klas.HeaderText = "Klas";
            this.Klas.Name = "Klas";
            // 
            // Reden
            // 
            this.Reden.HeaderText = "Reden";
            this.Reden.Items.AddRange(new object[] {
            "reden 1",
            "reden 2",
            "reden 3",
            "reden 4"});
            this.Reden.Name = "Reden";
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Appolon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 599);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.DataGridLeerlingen);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appolon";
            this.Text = "Appolon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Appolon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.DataGridView DataGridLeerlingen;
        private System.Windows.Forms.PictureBox btnPower;
        internal System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnLoad;
        public System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar StripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voornaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klas;
        private System.Windows.Forms.DataGridViewComboBoxColumn Reden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

