
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
            this.Submit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voornaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridLeerlingen
            // 
            this.DataGridLeerlingen.AllowUserToAddRows = false;
            this.DataGridLeerlingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLeerlingen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Submit,
            this.Naam,
            this.Voornaam,
            this.Klas,
            this.Reden,
            this.Tijd});
            this.DataGridLeerlingen.Location = new System.Drawing.Point(236, 184);
            this.DataGridLeerlingen.Name = "DataGridLeerlingen";
            this.DataGridLeerlingen.Size = new System.Drawing.Size(534, 238);
            this.DataGridLeerlingen.TabIndex = 31;
            // 
            // Submit
            // 
            this.Submit.HeaderText = "Submit";
            this.Submit.Name = "Submit";
            this.Submit.ReadOnly = true;
            this.Submit.Width = 50;
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
            // SmartschoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridLeerlingen);
            this.Name = "SmartschoolForm";
            this.Text = "SmartschoolForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLeerlingen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridLeerlingen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Submit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voornaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd;
    }
}