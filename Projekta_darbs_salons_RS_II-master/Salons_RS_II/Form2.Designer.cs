namespace Salons_RS_II
{
    partial class Form2
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
            this.Klientu_izvade_grid = new System.Windows.Forms.DataGridView();
            this.klienti = new System.Windows.Forms.Button();
            this.Precu_izvade_grid = new System.Windows.Forms.DataGridView();
            this.pakalpojumi = new System.Windows.Forms.Button();
            this.Pakalpojumi_izvade_grid = new System.Windows.Forms.DataGridView();
            this.pakalpojumuizvade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Klientu_izvade_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precu_izvade_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pakalpojumi_izvade_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Klientu_izvade_grid
            // 
            this.Klientu_izvade_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Klientu_izvade_grid.Location = new System.Drawing.Point(229, 3);
            this.Klientu_izvade_grid.Name = "Klientu_izvade_grid";
            this.Klientu_izvade_grid.Size = new System.Drawing.Size(559, 131);
            this.Klientu_izvade_grid.TabIndex = 4;
            // 
            // klienti
            // 
            this.klienti.Location = new System.Drawing.Point(80, 51);
            this.klienti.Name = "klienti";
            this.klienti.Size = new System.Drawing.Size(143, 23);
            this.klienti.TabIndex = 5;
            this.klienti.Text = "Klientu izvade";
            this.klienti.UseVisualStyleBackColor = true;
            this.klienti.Click += new System.EventHandler(this.button1_Click);
            // 
            // Precu_izvade_grid
            // 
            this.Precu_izvade_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Precu_izvade_grid.Location = new System.Drawing.Point(229, 140);
            this.Precu_izvade_grid.Name = "Precu_izvade_grid";
            this.Precu_izvade_grid.Size = new System.Drawing.Size(559, 150);
            this.Precu_izvade_grid.TabIndex = 6;
            // 
            // pakalpojumi
            // 
            this.pakalpojumi.Location = new System.Drawing.Point(80, 202);
            this.pakalpojumi.Name = "pakalpojumi";
            this.pakalpojumi.Size = new System.Drawing.Size(143, 23);
            this.pakalpojumi.TabIndex = 7;
            this.pakalpojumi.Text = "Preču izvade";
            this.pakalpojumi.UseVisualStyleBackColor = true;
            this.pakalpojumi.Click += new System.EventHandler(this.pakalpojumi_Click);
            // 
            // Pakalpojumi_izvade_grid
            // 
            this.Pakalpojumi_izvade_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pakalpojumi_izvade_grid.Location = new System.Drawing.Point(229, 296);
            this.Pakalpojumi_izvade_grid.Name = "Pakalpojumi_izvade_grid";
            this.Pakalpojumi_izvade_grid.Size = new System.Drawing.Size(559, 150);
            this.Pakalpojumi_izvade_grid.TabIndex = 8;
            // 
            // pakalpojumuizvade
            // 
            this.pakalpojumuizvade.Location = new System.Drawing.Point(80, 362);
            this.pakalpojumuizvade.Name = "pakalpojumuizvade";
            this.pakalpojumuizvade.Size = new System.Drawing.Size(143, 23);
            this.pakalpojumuizvade.TabIndex = 9;
            this.pakalpojumuizvade.Text = "Pakalpojumu izvade";
            this.pakalpojumuizvade.UseVisualStyleBackColor = true;
            this.pakalpojumuizvade.Click += new System.EventHandler(this.pakalpojumuizvade_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pakalpojumuizvade);
            this.Controls.Add(this.Pakalpojumi_izvade_grid);
            this.Controls.Add(this.pakalpojumi);
            this.Controls.Add(this.Precu_izvade_grid);
            this.Controls.Add(this.klienti);
            this.Controls.Add(this.Klientu_izvade_grid);
            this.Name = "Form2";
            this.Text = "Datu apskate";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Klientu_izvade_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precu_izvade_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pakalpojumi_izvade_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Klientu_izvade_grid;
        private System.Windows.Forms.Button klienti;
        private System.Windows.Forms.DataGridView Precu_izvade_grid;
        private System.Windows.Forms.Button pakalpojumi;
        private System.Windows.Forms.DataGridView Pakalpojumi_izvade_grid;
        private System.Windows.Forms.Button pakalpojumuizvade;
    }
}