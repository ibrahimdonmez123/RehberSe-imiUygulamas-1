﻿namespace RehberSeçimiUygulaması1
{
    partial class SonucuGoster
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
            this.lbl_rehberin_ismi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_rehberin_ismi
            // 
            this.lbl_rehberin_ismi.AutoSize = true;
            this.lbl_rehberin_ismi.Location = new System.Drawing.Point(260, 93);
            this.lbl_rehberin_ismi.Name = "lbl_rehberin_ismi";
            this.lbl_rehberin_ismi.Size = new System.Drawing.Size(13, 13);
            this.lbl_rehberin_ismi.TabIndex = 0;
            this.lbl_rehberin_ismi.Text = "4";
            // 
            // SonucuGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_rehberin_ismi);
            this.Name = "SonucuGoster";
            this.Text = "SonucuGoster";
            this.Load += new System.EventHandler(this.SonucuGoster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rehberin_ismi;
    }
}