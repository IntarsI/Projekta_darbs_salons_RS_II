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
            this.Klientu_izvade_grid.BackgroundColor = System.Drawing.Color.Silver;
            this.Klientu_izvade_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Klientu_izvade_grid.Location = new System.Drawing.Point(401, -12);
            this.Klientu_izvade_grid.Name = "Klientu_izvade_grid";
            this.Klientu_izvade_grid.Size = new System.Drawing.Size(1005, 216);
            this.Klientu_izvade_grid.TabIndex = 4;
            // 
            // klienti
            // 
            this.klienti.BackColor = System.Drawing.Color.Teal;
            this.klienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.klienti.ForeColor = System.Drawing.Color.White;
            this.klienti.Location = new System.Drawing.Point(78, 57);
            this.klienti.Name = "klienti";
            this.klienti.Size = new System.Drawing.Size(199, 91);
            this.klienti.TabIndex = 5;
            this.klienti.Text = "Klientu izvade";
            this.klienti.UseVisualStyleBackColor = false;
            this.klienti.Click += new System.EventHandler(this.button1_Click);
            // 
            // Precu_izvade_grid
            // 
            this.Precu_izvade_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Precu_izvade_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Precu_izvade_grid.Location = new System.Drawing.Point(401, 210);
            this.Precu_izvade_grid.Name = "Precu_izvade_grid";
            this.Precu_izvade_grid.Size = new System.Drawing.Size(1005, 217);
            this.Precu_izvade_grid.TabIndex = 6;
            // 
            // pakalpojumi
            // 
            this.pakalpojumi.BackColor = System.Drawing.Color.Teal;
            this.pakalpojumi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pakalpojumi.ForeColor = System.Drawing.Color.White;
            this.pakalpojumi.Location = new System.Drawing.Point(78, 271);
            this.pakalpojumi.Name = "pakalpojumi";
            this.pakalpojumi.Size = new System.Drawing.Size(199, 94);
            this.pakalpojumi.TabIndex = 7;
            this.pakalpojumi.Text = "Preču izvade";
            this.pakalpojumi.UseVisualStyleBackColor = false;
            this.pakalpojumi.Click += new System.EventHandler(this.pakalpojumi_Click);
            // 
            // Pakalpojumi_izvade_grid
            // 
            this.Pakalpojumi_izvade_grid.BackgroundColor = System.Drawing.Color.Silver;
            this.Pakalpojumi_izvade_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pakalpojumi_izvade_grid.Location = new System.Drawing.Point(401, 433);
            this.Pakalpojumi_izvade_grid.Name = "Pakalpojumi_izvade_grid";
            this.Pakalpojumi_izvade_grid.Size = new System.Drawing.Size(1005, 219);
            this.Pakalpojumi_izvade_grid.TabIndex = 8;
            // 
            // pakalpojumuizvade
            // 
            this.pakalpojumuizvade.BackColor = System.Drawing.Color.Teal;
            this.pakalpojumuizvade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pakalpojumuizvade.ForeColor = System.Drawing.Color.White;
            this.pakalpojumuizvade.Location = new System.Drawing.Point(78, 487);
            this.pakalpojumuizvade.Name = "pakalpojumuizvade";
            this.pakalpojumuizvade.Size = new System.Drawing.Size(199, 94);
            this.pakalpojumuizvade.TabIndex = 9;
            this.pakalpojumuizvade.Text = "Pakalpojumu izvade";
            this.pakalpojumuizvade.UseVisualStyleBackColor = false;
            this.pakalpojumuizvade.Click += new System.EventHandler(this.pakalpojumuizvade_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1418, 652);
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