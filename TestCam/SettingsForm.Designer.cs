﻿namespace TestCam
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxInputs = new System.Windows.Forms.ComboBox();
            this.btnCloseSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera";
            // 
            // cboxInputs
            // 
            this.cboxInputs.FormattingEnabled = true;
            this.cboxInputs.Location = new System.Drawing.Point(119, 61);
            this.cboxInputs.Name = "cboxInputs";
            this.cboxInputs.Size = new System.Drawing.Size(222, 21);
            this.cboxInputs.TabIndex = 4;
            // 
            // btnCloseSettings
            // 
            this.btnCloseSettings.Location = new System.Drawing.Point(399, 58);
            this.btnCloseSettings.Name = "btnCloseSettings";
            this.btnCloseSettings.Size = new System.Drawing.Size(75, 23);
            this.btnCloseSettings.TabIndex = 6;
            this.btnCloseSettings.Text = "Close";
            this.btnCloseSettings.UseVisualStyleBackColor = true;
            this.btnCloseSettings.Click += new System.EventHandler(this.btnCloseSettings_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 165);
            this.Controls.Add(this.btnCloseSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxInputs);
            this.Name = "SettingsForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxInputs;
        private System.Windows.Forms.Button btnCloseSettings;
    }
}