
namespace Apollon
{
    partial class SmartschoolForm
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
            this.DataGridLeerlingen = new System.Windows.Forms.DataGridView();
            this.Submitted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voornaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridLeerlingen
            // 
            this.DataGridLeerlingen.AllowUserToAddRows = false;
            this.DataGridLeerlingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLeerlingen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Submitted,
            this.Naam,
            this.Voornaam,
            this.Klas,
            this.Reden,
            this.Tijd});
            this.DataGridLeerlingen.Location = new System.Drawing.Point(246, 190);
            this.DataGridLeerlingen.Name = "DataGridLeerlingen";
            this.DataGridLeerlingen.Size = new System.Drawing.Size(533, 238);
            this.DataGridLeerlingen.TabIndex = 31;
            // 
            // Submitted
            // 
            this.Submitted.HeaderText = "Sent";
            this.Submitted.Name = "Submitted";
            this.Submitted.ReadOnly = true;
            this.Submitted.Width = 50;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 38);
            this.label1.TabIndex = 33;
            this.label1.Text = "This part of Apollon is still in betaTesting.\r\nWe Highly recommend you saving the" +
    " list Leerling before launching this.";
            // 
            // SmartschoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridLeerlingen);
            this.Name = "SmartschoolForm";
            this.Text = "SmartschoolForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridLeerlingen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Submitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voornaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}