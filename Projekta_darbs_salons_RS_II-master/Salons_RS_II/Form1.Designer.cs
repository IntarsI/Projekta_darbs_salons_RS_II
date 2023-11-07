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
            this.Datu_ievade.Location = new System.Drawing.Point(306, 149);
            this.Datu_ievade.Name = "Datu_ievade";
            this.Datu_ievade.Size = new System.Drawing.Size(156, 23);
            this.Datu_ievade.TabIndex = 0;
            this.Datu_ievade.Text = "Main Menu";
            this.Datu_ievade.UseVisualStyleBackColor = true;
            this.Datu_ievade.Click += new System.EventHandler(this.Datu_ievade_Click);
            // 
            // Dati_no_DB
            // 
            this.Dati_no_DB.Location = new System.Drawing.Point(306, 178);
            this.Dati_no_DB.Name = "Dati_no_DB";
            this.Dati_no_DB.Size = new System.Drawing.Size(156, 23);
            this.Dati_no_DB.TabIndex = 1;
            this.Dati_no_DB.Text = "Datu uzrāde";
            this.Dati_no_DB.UseVisualStyleBackColor = true;
            this.Dati_no_DB.Click += new System.EventHandler(this.Dati_no_DB_Click);
            // 
            // Ceka_izvede
            // 
            this.Ceka_izvede.Location = new System.Drawing.Point(306, 207);
            this.Ceka_izvede.Name = "Ceka_izvede";
            this.Ceka_izvede.Size = new System.Drawing.Size(156, 23);
            this.Ceka_izvede.TabIndex = 2;
            this.Ceka_izvede.Text = "Čeka saglabāšana";
            this.Ceka_izvede.UseVisualStyleBackColor = true;
            this.Ceka_izvede.Click += new System.EventHandler(this.Ceka_izvede_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ceka_izvede);
            this.Controls.Add(this.Dati_no_DB);
            this.Controls.Add(this.Datu_ievade);
            this.Name = "Form1";
            this.Text = "Datu ievade";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Ceka_izvede;
        private System.Windows.Forms.Button Dati_no_DB;
        private System.Windows.Forms.Button Datu_ievade;
    }
}

