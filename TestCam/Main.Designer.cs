namespace TestCam
{
    partial class Apollon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apollon));
            this.pbox = new System.Windows.Forms.PictureBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.DataGridLeerlingen = new System.Windows.Forms.DataGridView();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voornaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbReden = new System.Windows.Forms.ListBox();
            this.pnlPower = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.PictureBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MijnFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MijnBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtbNaamInput = new System.Windows.Forms.TextBox();
            this.txtbVoornaamInput = new System.Windows.Forms.TextBox();
            this.txtbKlasInput = new System.Windows.Forms.TextBox();
            this.btnAddLln = new System.Windows.Forms.PictureBox();
            this.btnMakeLln = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnlPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.pnlLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddLln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMakeLln)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(233, 73);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(344, 256);
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(13, 559);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(61, 13);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "lblComment";
            this.lblComment.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(13, 536);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "lblResult";
            this.lblResult.Visible = false;
            // 
            // DataGridLeerlingen
            // 
            this.DataGridLeerlingen.AllowUserToAddRows = false;
            this.DataGridLeerlingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLeerlingen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naam,
            this.Voornaam,
            this.Klas,
            this.Reden,
            this.Tijd,
            this.ID});
            this.DataGridLeerlingen.Location = new System.Drawing.Point(234, 368);
            this.DataGridLeerlingen.Name = "DataGridLeerlingen";
            this.DataGridLeerlingen.Size = new System.Drawing.Size(553, 238);
            this.DataGridLeerlingen.TabIndex = 30;
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
            this.Klas.Width = 70;
            // 
            // Reden
            // 
            this.Reden.HeaderText = "Reden";
            this.Reden.Name = "Reden";
            // 
            // Tijd
            // 
            this.Tijd.HeaderText = "Tijd";
            this.Tijd.Name = "Tijd";
            this.Tijd.Width = 70;
            // 
            // ID
            // 
            this.ID.FillWeight = 80F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripProgressBar,
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
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
            // lbReden
            // 
            this.lbReden.FormattingEnabled = true;
            this.lbReden.Location = new System.Drawing.Point(81, 368);
            this.lbReden.Name = "lbReden";
            this.lbReden.Size = new System.Drawing.Size(120, 238);
            this.lbReden.TabIndex = 25;
            this.lbReden.SelectedIndexChanged += new System.EventHandler(this.lbReden_SelectedIndexChanged);
            // 
            // pnlPower
            // 
            this.pnlPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.pnlPower.Controls.Add(this.btnPower);
            this.pnlPower.Location = new System.Drawing.Point(3, 11);
            this.pnlPower.Name = "pnlPower";
            this.pnlPower.Size = new System.Drawing.Size(200, 65);
            this.pnlPower.TabIndex = 22;
            this.pnlPower.Click += new System.EventHandler(this.btnPower_Click);
            this.pnlPower.MouseEnter += new System.EventHandler(this.btnPower_MouseEnter);
            this.pnlPower.MouseLeave += new System.EventHandler(this.btnPower_MouseLeave);
            // 
            // btnPower
            // 
            this.btnPower.Image = ((System.Drawing.Image)(resources.GetObject("btnPower.Image")));
            this.btnPower.Location = new System.Drawing.Point(78, 10);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(45, 45);
            this.btnPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPower.TabIndex = 14;
            this.btnPower.TabStop = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            this.btnPower.MouseEnter += new System.EventHandler(this.btnPower_MouseEnter);
            this.btnPower.MouseLeave += new System.EventHandler(this.btnPower_MouseLeave);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Location = new System.Drawing.Point(205, 11);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(200, 65);
            this.pnlSettings.TabIndex = 23;
            this.pnlSettings.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pnlSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.pnlSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(80, 9);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 45);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 11;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.pictureBox3_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Location = new System.Drawing.Point(407, 11);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(200, 65);
            this.pnlSave.TabIndex = 23;
            this.pnlSave.Click += new System.EventHandler(this.btnSave_Click);
            this.pnlSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.pnlSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(78, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 15;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.pnlLoad.Controls.Add(this.btnLoad);
            this.pnlLoad.Location = new System.Drawing.Point(609, 11);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(200, 65);
            this.pnlLoad.TabIndex = 23;
            this.pnlLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.pnlLoad.MouseEnter += new System.EventHandler(this.btnLoad_MouseEnter);
            this.pnlLoad.MouseLeave += new System.EventHandler(this.btnLoad_MouseLeave);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(77, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(45, 45);
            this.btnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoad.TabIndex = 16;
            this.btnLoad.TabStop = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.MouseEnter += new System.EventHandler(this.btnLoad_MouseEnter);
            this.btnLoad.MouseLeave += new System.EventHandler(this.btnLoad_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.pnlLoad);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.pnlSettings);
            this.panel1.Controls.Add(this.pnlPower);
            this.panel1.Location = new System.Drawing.Point(0, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 78);
            this.panel1.TabIndex = 21;
            // 
            // MijnFileDialog
            // 
            this.MijnFileDialog.FileName = "Data";
            // 
            // txtbNaamInput
            // 
            this.txtbNaamInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbNaamInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtbNaamInput.Location = new System.Drawing.Point(273, 342);
            this.txtbNaamInput.Name = "txtbNaamInput";
            this.txtbNaamInput.Size = new System.Drawing.Size(100, 20);
            this.txtbNaamInput.TabIndex = 18;
            this.txtbNaamInput.Visible = false;
            // 
            // txtbVoornaamInput
            // 
            this.txtbVoornaamInput.Location = new System.Drawing.Point(377, 342);
            this.txtbVoornaamInput.Name = "txtbVoornaamInput";
            this.txtbVoornaamInput.Size = new System.Drawing.Size(100, 20);
            this.txtbVoornaamInput.TabIndex = 19;
            this.txtbVoornaamInput.Visible = false;
            // 
            // txtbKlasInput
            // 
            this.txtbKlasInput.Location = new System.Drawing.Point(479, 342);
            this.txtbKlasInput.Name = "txtbKlasInput";
            this.txtbKlasInput.Size = new System.Drawing.Size(66, 20);
            this.txtbKlasInput.TabIndex = 20;
            this.txtbKlasInput.Visible = false;
            // 
            // btnAddLln
            // 
            this.btnAddLln.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLln.Image")));
            this.btnAddLln.Location = new System.Drawing.Point(235, 335);
            this.btnAddLln.Name = "btnAddLln";
            this.btnAddLln.Size = new System.Drawing.Size(32, 32);
            this.btnAddLln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddLln.TabIndex = 14;
            this.btnAddLln.TabStop = false;
            this.btnAddLln.Click += new System.EventHandler(this.btnAddLln_Click);
            this.btnAddLln.MouseEnter += new System.EventHandler(this.btnAddLln_MouseEnter);
            this.btnAddLln.MouseLeave += new System.EventHandler(this.btnAddLln_MouseLeave);
            // 
            // btnMakeLln
            // 
            this.btnMakeLln.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeLln.Image")));
            this.btnMakeLln.Location = new System.Drawing.Point(548, 339);
            this.btnMakeLln.Name = "btnMakeLln";
            this.btnMakeLln.Size = new System.Drawing.Size(25, 25);
            this.btnMakeLln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMakeLln.TabIndex = 14;
            this.btnMakeLln.TabStop = false;
            this.btnMakeLln.Visible = false;
            this.btnMakeLln.Click += new System.EventHandler(this.btnMakeLln_Click);
            this.btnMakeLln.MouseEnter += new System.EventHandler(this.btnMakeLln_MouseEnter);
            this.btnMakeLln.MouseLeave += new System.EventHandler(this.btnMakeLln_MouseLeave);
            // 
            // Apollon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(811, 642);
            this.Controls.Add(this.btnMakeLln);
            this.Controls.Add(this.btnAddLln);
            this.Controls.Add(this.txtbKlasInput);
            this.Controls.Add(this.txtbVoornaamInput);
            this.Controls.Add(this.txtbNaamInput);
            this.Controls.Add(this.lbReden);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DataGridLeerlingen);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apollon";
            this.Text = "Apollon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Appolon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlPower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.pnlLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddLln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMakeLln)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.DataGridView DataGridLeerlingen;
        internal System.Windows.Forms.Label lblComment;
        public System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar StripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblError;
        private System.Windows.Forms.ListBox lbReden;
        private System.Windows.Forms.Panel pnlPower;
        private System.Windows.Forms.PictureBox btnPower;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.PictureBox btnLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog MijnFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voornaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.FolderBrowserDialog MijnBrowserDialog;
        private System.Windows.Forms.TextBox txtbNaamInput;
        private System.Windows.Forms.TextBox txtbVoornaamInput;
        private System.Windows.Forms.TextBox txtbKlasInput;
        private System.Windows.Forms.PictureBox btnAddLln;
        private System.Windows.Forms.PictureBox btnMakeLln;
    }
}

