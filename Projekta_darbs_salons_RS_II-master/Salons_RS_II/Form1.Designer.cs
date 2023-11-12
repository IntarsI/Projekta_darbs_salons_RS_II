namespace Salons_RS_II
{
    partial class Form1
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Datu_ievade = new System.Windows.Forms.Button();
            this.Dati_no_DB = new System.Windows.Forms.Button();
            this.Ceka_izvede = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Datu_ievade
            // 
            this.Datu_ievade.BackColor = System.Drawing.Color.Teal;
            this.Datu_ievade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Datu_ievade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Datu_ievade.ForeColor = System.Drawing.Color.Transparent;
            this.Datu_ievade.Location = new System.Drawing.Point(26, 131);
            this.Datu_ievade.Name = "Datu_ievade";
            this.Datu_ievade.Size = new System.Drawing.Size(168, 99);
            this.Datu_ievade.TabIndex = 0;
            this.Datu_ievade.Text = "Datu ievade";
            this.Datu_ievade.UseVisualStyleBackColor = false;
            this.Datu_ievade.Click += new System.EventHandler(this.Datu_ievade_Click);
            // 
            // Dati_no_DB
            // 
            this.Dati_no_DB.BackColor = System.Drawing.Color.Teal;
            this.Dati_no_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Dati_no_DB.ForeColor = System.Drawing.Color.Transparent;
            this.Dati_no_DB.Location = new System.Drawing.Point(317, 131);
            this.Dati_no_DB.Name = "Dati_no_DB";
            this.Dati_no_DB.Size = new System.Drawing.Size(168, 99);
            this.Dati_no_DB.TabIndex = 1;
            this.Dati_no_DB.Text = "Datu uzrāde";
            this.Dati_no_DB.UseVisualStyleBackColor = false;
            this.Dati_no_DB.Click += new System.EventHandler(this.Dati_no_DB_Click);
            // 
            // Ceka_izvede
            // 
            this.Ceka_izvede.BackColor = System.Drawing.Color.Teal;
            this.Ceka_izvede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Ceka_izvede.ForeColor = System.Drawing.Color.Transparent;
            this.Ceka_izvede.Location = new System.Drawing.Point(606, 131);
            this.Ceka_izvede.Name = "Ceka_izvede";
            this.Ceka_izvede.Size = new System.Drawing.Size(168, 99);
            this.Ceka_izvede.TabIndex = 2;
            this.Ceka_izvede.Text = "Čeka saglabāšana";
            this.Ceka_izvede.UseVisualStyleBackColor = false;
            this.Ceka_izvede.Click += new System.EventHandler(this.Ceka_izvede_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "ANNAS SKAISTUMKOPŠANAS SALONS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ceka_izvede);
            this.Controls.Add(this.Dati_no_DB);
            this.Controls.Add(this.Datu_ievade);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Ceka_izvede;
        private System.Windows.Forms.Button Dati_no_DB;
        private System.Windows.Forms.Button Datu_ievade;
        private System.Windows.Forms.Label label1;
    }
}

