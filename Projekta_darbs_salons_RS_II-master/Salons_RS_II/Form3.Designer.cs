﻿namespace Salons_RS_II
{
    partial class Form3
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
            this.klientaid = new System.Windows.Forms.TextBox();
            this.pakalpojumaid = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Izvele_klients = new System.Windows.Forms.Button();
            this.pakalpojuma_izvele = new System.Windows.Forms.Button();
            this.Ceks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // klientaid
            // 
            this.klientaid.Location = new System.Drawing.Point(78, 77);
            this.klientaid.Name = "klientaid";
            this.klientaid.Size = new System.Drawing.Size(100, 20);
            this.klientaid.TabIndex = 0;
            this.klientaid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pakalpojumaid
            // 
            this.pakalpojumaid.Location = new System.Drawing.Point(78, 147);
            this.pakalpojumaid.Name = "pakalpojumaid";
            this.pakalpojumaid.Size = new System.Drawing.Size(100, 20);
            this.pakalpojumaid.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(328, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(473, 447);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Izvele_klients
            // 
            this.Izvele_klients.Location = new System.Drawing.Point(184, 77);
            this.Izvele_klients.Name = "Izvele_klients";
            this.Izvele_klients.Size = new System.Drawing.Size(138, 23);
            this.Izvele_klients.TabIndex = 3;
            this.Izvele_klients.Text = "Izvēlēties klientu";
            this.Izvele_klients.UseVisualStyleBackColor = true;
            this.Izvele_klients.Click += new System.EventHandler(this.Izvele_klients_Click);
            // 
            // pakalpojuma_izvele
            // 
            this.pakalpojuma_izvele.Location = new System.Drawing.Point(184, 147);
            this.pakalpojuma_izvele.Name = "pakalpojuma_izvele";
            this.pakalpojuma_izvele.Size = new System.Drawing.Size(138, 23);
            this.pakalpojuma_izvele.TabIndex = 4;
            this.pakalpojuma_izvele.Text = "Izvēlēties pakalpojumu";
            this.pakalpojuma_izvele.UseVisualStyleBackColor = true;
            this.pakalpojuma_izvele.Click += new System.EventHandler(this.pakalpojuma_izvele_Click);
            // 
            // Ceks
            // 
            this.Ceks.Location = new System.Drawing.Point(102, 249);
            this.Ceks.Name = "Ceks";
            this.Ceks.Size = new System.Drawing.Size(114, 23);
            this.Ceks.TabIndex = 5;
            this.Ceks.Text = "Izveidot čeku";
            this.Ceks.UseVisualStyleBackColor = true;
            this.Ceks.Click += new System.EventHandler(this.Ceks_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ceks);
            this.Controls.Add(this.pakalpojuma_izvele);
            this.Controls.Add(this.Izvele_klients);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pakalpojumaid);
            this.Controls.Add(this.klientaid);
            this.Name = "Form3";
            this.Text = "Ceka izveide";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox klientaid;
        private System.Windows.Forms.TextBox pakalpojumaid;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Izvele_klients;
        private System.Windows.Forms.Button pakalpojuma_izvele;
        private System.Windows.Forms.Button Ceks;
    }
}