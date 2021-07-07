namespace Main
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
            this.MijnFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MijnBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtbNaamInput = new System.Windows.Forms.TextBox();
            this.txtbVoornaamInput = new System.Windows.Forms.TextBox();
            this.txtbKlasInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSmartschool = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnPower = new System.Windows.Forms.PictureBox();
            this.btnMakeLln = new System.Windows.Forms.PictureBox();
            this.btnAddLln = new System.Windows.Forms.PictureBox();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.lblUserAddPlaceHolder = new System.Windows.Forms.Label();
            this.DataGridLlnState = new System.Windows.Forms.PictureBox();
            this.btnUndo = new System.Windows.Forms.PictureBox();
            this.lblUndo = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.txtbReden = new System.Windows.Forms.RichTextBox();
            this.btnReden = new System.Windows.Forms.Button();
            this.btnRedenAdd = new System.Windows.Forms.PictureBox();
            this.btnRedenRemove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSmartschool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMakeLln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddLln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLlnState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedenAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedenRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(416, 576);
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
            this.lblResult.Location = new System.Drawing.Point(313, 576);
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
            this.DataGridLeerlingen.Location = new System.Drawing.Point(133, 324);
            this.DataGridLeerlingen.Name = "DataGridLeerlingen";
            this.DataGridLeerlingen.Size = new System.Drawing.Size(553, 238);
            this.DataGridLeerlingen.TabIndex = 30;
            this.DataGridLeerlingen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridLeerlingen_CellValueChanged);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
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
            this.lbReden.Location = new System.Drawing.Point(561, 14);
            this.lbReden.Name = "lbReden";
            this.lbReden.Size = new System.Drawing.Size(115, 238);
            this.lbReden.TabIndex = 25;
            this.lbReden.Visible = false;
            this.lbReden.SelectedIndexChanged += new System.EventHandler(this.lbReden_SelectedIndexChanged);
            // 
            // MijnFileDialog
            // 
            this.MijnFileDialog.FileName = "Data";
            // 
            // txtbNaamInput
            // 
            this.txtbNaamInput.Location = new System.Drawing.Point(302, 296);
            this.txtbNaamInput.Name = "txtbNaamInput";
            this.txtbNaamInput.Size = new System.Drawing.Size(100, 20);
            this.txtbNaamInput.TabIndex = 18;
            this.txtbNaamInput.Visible = false;
            // 
            // txtbVoornaamInput
            // 
            this.txtbVoornaamInput.Location = new System.Drawing.Point(406, 296);
            this.txtbVoornaamInput.Name = "txtbVoornaamInput";
            this.txtbVoornaamInput.Size = new System.Drawing.Size(100, 20);
            this.txtbVoornaamInput.TabIndex = 19;
            this.txtbVoornaamInput.Visible = false;
            // 
            // txtbKlasInput
            // 
            this.txtbKlasInput.Location = new System.Drawing.Point(508, 296);
            this.txtbKlasInput.Name = "txtbKlasInput";
            this.txtbKlasInput.Size = new System.Drawing.Size(66, 20);
            this.txtbKlasInput.TabIndex = 20;
            this.txtbKlasInput.Visible = false;
            this.txtbKlasInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbKlasInput_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSmartschool);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnPower);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 605);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Send";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Export";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Load";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Power";
            // 
            // btnSmartschool
            // 
            this.btnSmartschool.Image = ((System.Drawing.Image)(resources.GetObject("btnSmartschool.Image")));
            this.btnSmartschool.Location = new System.Drawing.Point(30, 495);
            this.btnSmartschool.Name = "btnSmartschool";
            this.btnSmartschool.Size = new System.Drawing.Size(50, 50);
            this.btnSmartschool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSmartschool.TabIndex = 17;
            this.btnSmartschool.TabStop = false;
            this.btnSmartschool.Click += new System.EventHandler(this.btnSmartschool_Click);
            this.btnSmartschool.MouseEnter += new System.EventHandler(this.btnSmartschool_MouseEnter);
            this.btnSmartschool.MouseLeave += new System.EventHandler(this.btnSmartschool_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(25, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
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
            this.btnLoad.Location = new System.Drawing.Point(25, 275);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(50, 50);
            this.btnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoad.TabIndex = 16;
            this.btnLoad.TabStop = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.MouseEnter += new System.EventHandler(this.btnLoad_MouseEnter);
            this.btnLoad.MouseLeave += new System.EventHandler(this.btnLoad_MouseLeave);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(25, 165);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(50, 50);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 11;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // btnPower
            // 
            this.btnPower.Image = ((System.Drawing.Image)(resources.GetObject("btnPower.Image")));
            this.btnPower.Location = new System.Drawing.Point(25, 55);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(50, 50);
            this.btnPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPower.TabIndex = 14;
            this.btnPower.TabStop = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            this.btnPower.MouseEnter += new System.EventHandler(this.btnPower_MouseEnter);
            this.btnPower.MouseLeave += new System.EventHandler(this.btnPower_MouseLeave);
            // 
            // btnMakeLln
            // 
            this.btnMakeLln.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeLln.Image")));
            this.btnMakeLln.Location = new System.Drawing.Point(577, 293);
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
            // btnAddLln
            // 
            this.btnAddLln.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLln.Image")));
            this.btnAddLln.Location = new System.Drawing.Point(264, 289);
            this.btnAddLln.Name = "btnAddLln";
            this.btnAddLln.Size = new System.Drawing.Size(32, 32);
            this.btnAddLln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddLln.TabIndex = 14;
            this.btnAddLln.TabStop = false;
            this.btnAddLln.Visible = false;
            this.btnAddLln.Click += new System.EventHandler(this.btnAddLln_Click);
            this.btnAddLln.MouseEnter += new System.EventHandler(this.btnAddLln_MouseEnter);
            this.btnAddLln.MouseLeave += new System.EventHandler(this.btnAddLln_MouseLeave);
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.White;
            this.pbox.Location = new System.Drawing.Point(214, 12);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(372, 247);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            // 
            // lblUserAddPlaceHolder
            // 
            this.lblUserAddPlaceHolder.AutoSize = true;
            this.lblUserAddPlaceHolder.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAddPlaceHolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserAddPlaceHolder.Location = new System.Drawing.Point(302, 280);
            this.lblUserAddPlaceHolder.Name = "lblUserAddPlaceHolder";
            this.lblUserAddPlaceHolder.Size = new System.Drawing.Size(236, 15);
            this.lblUserAddPlaceHolder.TabIndex = 18;
            this.lblUserAddPlaceHolder.Text = "Naam                 Voornaam         Klas\r\n";
            this.lblUserAddPlaceHolder.Visible = false;
            // 
            // DataGridLlnState
            // 
            this.DataGridLlnState.Image = ((System.Drawing.Image)(resources.GetObject("DataGridLlnState.Image")));
            this.DataGridLlnState.Location = new System.Drawing.Point(692, 527);
            this.DataGridLlnState.Name = "DataGridLlnState";
            this.DataGridLlnState.Size = new System.Drawing.Size(35, 35);
            this.DataGridLlnState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DataGridLlnState.TabIndex = 31;
            this.DataGridLlnState.TabStop = false;
            this.DataGridLlnState.Visible = false;
            this.DataGridLlnState.Click += new System.EventHandler(this.DataGridLlnState_Click);
            this.DataGridLlnState.MouseEnter += new System.EventHandler(this.DataGridLlnState_MouseEnter);
            this.DataGridLlnState.MouseLeave += new System.EventHandler(this.DataGridLlnState_MouseLeave);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(692, 468);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(35, 35);
            this.btnUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUndo.TabIndex = 31;
            this.btnUndo.TabStop = false;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            this.btnUndo.MouseEnter += new System.EventHandler(this.btnUndo_MouseEnter);
            this.btnUndo.MouseLeave += new System.EventHandler(this.btnUndo_MouseLeave);
            // 
            // lblUndo
            // 
            this.lblUndo.AutoSize = true;
            this.lblUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndo.ForeColor = System.Drawing.Color.White;
            this.lblUndo.Location = new System.Drawing.Point(691, 452);
            this.lblUndo.Name = "lblUndo";
            this.lblUndo.Size = new System.Drawing.Size(37, 13);
            this.lblUndo.TabIndex = 33;
            this.lblUndo.Text = "Undo";
            this.lblUndo.Visible = false;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(692, 511);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(36, 13);
            this.lblSave.TabIndex = 34;
            this.lblSave.Text = "Save";
            this.lblSave.Visible = false;
            // 
            // txtbReden
            // 
            this.txtbReden.Location = new System.Drawing.Point(561, 158);
            this.txtbReden.Name = "txtbReden";
            this.txtbReden.Size = new System.Drawing.Size(115, 68);
            this.txtbReden.TabIndex = 35;
            this.txtbReden.Text = "";
            this.txtbReden.Visible = false;
            // 
            // btnReden
            // 
            this.btnReden.Location = new System.Drawing.Point(561, 237);
            this.btnReden.Name = "btnReden";
            this.btnReden.Size = new System.Drawing.Size(115, 23);
            this.btnReden.TabIndex = 36;
            this.btnReden.Text = "Confirm";
            this.btnReden.UseVisualStyleBackColor = true;
            this.btnReden.Visible = false;
            this.btnReden.Click += new System.EventHandler(this.btnReden_Click);
            // 
            // btnRedenAdd
            // 
            this.btnRedenAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnRedenAdd.Image")));
            this.btnRedenAdd.Location = new System.Drawing.Point(692, 174);
            this.btnRedenAdd.Name = "btnRedenAdd";
            this.btnRedenAdd.Size = new System.Drawing.Size(25, 25);
            this.btnRedenAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRedenAdd.TabIndex = 37;
            this.btnRedenAdd.TabStop = false;
            this.btnRedenAdd.Visible = false;
            this.btnRedenAdd.Click += new System.EventHandler(this.btnRedenAdd_Click);
            this.btnRedenAdd.MouseEnter += new System.EventHandler(this.btnRedenAdd_MouseEnter);
            this.btnRedenAdd.MouseLeave += new System.EventHandler(this.btnRedenAdd_MouseLeave);
            // 
            // btnRedenRemove
            // 
            this.btnRedenRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRedenRemove.Image")));
            this.btnRedenRemove.Location = new System.Drawing.Point(692, 14);
            this.btnRedenRemove.Name = "btnRedenRemove";
            this.btnRedenRemove.Size = new System.Drawing.Size(25, 25);
            this.btnRedenRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRedenRemove.TabIndex = 38;
            this.btnRedenRemove.TabStop = false;
            this.btnRedenRemove.Visible = false;
            this.btnRedenRemove.Click += new System.EventHandler(this.btnRedenRemove_Click);
            this.btnRedenRemove.MouseEnter += new System.EventHandler(this.btnRedenRemove_MouseEnter);
            this.btnRedenRemove.MouseLeave += new System.EventHandler(this.btnRedenRemove_MouseLeave);
            // 
            // Apollon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(737, 626);
            this.Controls.Add(this.btnRedenRemove);
            this.Controls.Add(this.btnRedenAdd);
            this.Controls.Add(this.btnReden);
            this.Controls.Add(this.txtbReden);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblUndo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.DataGridLlnState);
            this.Controls.Add(this.lblUserAddPlaceHolder);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apollon";
            this.Text = "Apollon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Appolon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSmartschool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMakeLln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddLln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLlnState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedenAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedenRemove)).EndInit();
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
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnLoad;
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
        private System.Windows.Forms.PictureBox btnPower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSmartschool;
        private System.Windows.Forms.Label lblUserAddPlaceHolder;
        private System.Windows.Forms.PictureBox DataGridLlnState;
        private System.Windows.Forms.PictureBox btnUndo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUndo;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.RichTextBox txtbReden;
        private System.Windows.Forms.Button btnReden;
        private System.Windows.Forms.PictureBox btnRedenAdd;
        private System.Windows.Forms.PictureBox btnRedenRemove;
    }
}

