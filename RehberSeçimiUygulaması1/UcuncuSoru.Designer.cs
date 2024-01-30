namespace RehberSeçimiUygulaması1
{
    partial class UcuncuSoru
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_ortadogulu = new System.Windows.Forms.CheckBox();
            this.checkBox_amerikali = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sonucu göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen turun kapsamına göre uygun olanı işareteyiniz";
            // 
            // checkBox_ortadogulu
            // 
            this.checkBox_ortadogulu.AutoSize = true;
            this.checkBox_ortadogulu.Location = new System.Drawing.Point(203, 197);
            this.checkBox_ortadogulu.Name = "checkBox_ortadogulu";
            this.checkBox_ortadogulu.Size = new System.Drawing.Size(78, 17);
            this.checkBox_ortadogulu.TabIndex = 5;
            this.checkBox_ortadogulu.Text = "Ortadoğulu";
            this.checkBox_ortadogulu.UseVisualStyleBackColor = true;
            // 
            // checkBox_amerikali
            // 
            this.checkBox_amerikali.AutoSize = true;
            this.checkBox_amerikali.Location = new System.Drawing.Point(212, 108);
            this.checkBox_amerikali.Name = "checkBox_amerikali";
            this.checkBox_amerikali.Size = new System.Drawing.Size(68, 17);
            this.checkBox_amerikali.TabIndex = 6;
            this.checkBox_amerikali.Text = "Amerikalı";
            this.checkBox_amerikali.UseVisualStyleBackColor = true;
            // 
            // UcuncuSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_ortadogulu);
            this.Controls.Add(this.checkBox_amerikali);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "UcuncuSoru";
            this.Text = "UcuncuSoru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_ortadogulu;
        private System.Windows.Forms.CheckBox checkBox_amerikali;
    }
}