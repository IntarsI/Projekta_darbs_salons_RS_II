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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Savienosanas_test = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.klientavards = new System.Windows.Forms.TextBox();
            this.klientaepasts = new System.Windows.Forms.TextBox();
            this.klientauzvards = new System.Windows.Forms.TextBox();
            this.klientanumurs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.klienta_registresana = new System.Windows.Forms.Button();
            this.preces_registresana = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.precescena = new System.Windows.Forms.TextBox();
            this.precesnosaukums = new System.Windows.Forms.TextBox();
            this.precestilpums = new System.Windows.Forms.TextBox();
            this.precesveids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.klientsprocedura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pakalpojums_pieejamiba = new System.Windows.Forms.TextBox();
            this.pakalpojums_nosaukums = new System.Windows.Forms.TextBox();
            this.pakalpojums_cena = new System.Windows.Forms.TextBox();
            this.pakalpojums_pecesid = new System.Windows.Forms.TextBox();
            this.Pakalpojums = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pierakstisana_pakalpojums = new System.Windows.Forms.Button();
            this.atskaites_izveidosana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Savienosanas_test
            // 
            this.Savienosanas_test.Location = new System.Drawing.Point(21, 53);
            this.Savienosanas_test.Name = "Savienosanas_test";
            this.Savienosanas_test.Size = new System.Drawing.Size(124, 23);
            this.Savienosanas_test.TabIndex = 4;
            this.Savienosanas_test.Text = "Savienosanas_test";
            this.Savienosanas_test.UseVisualStyleBackColor = true;
            this.Savienosanas_test.Click += new System.EventHandler(this.Savienosanas_test_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // klientavards
            // 
            this.klientavards.Location = new System.Drawing.Point(548, 287);
            this.klientavards.Name = "klientavards";
            this.klientavards.Size = new System.Drawing.Size(100, 20);
            this.klientavards.TabIndex = 6;
            this.klientavards.TextChanged += new System.EventHandler(this.klientavards_TextChanged);
            // 
            // klientaepasts
            // 
            this.klientaepasts.Location = new System.Drawing.Point(548, 358);
            this.klientaepasts.Name = "klientaepasts";
            this.klientaepasts.Size = new System.Drawing.Size(100, 20);
            this.klientaepasts.TabIndex = 7;
            // 
            // klientauzvards
            // 
            this.klientauzvards.Location = new System.Drawing.Point(548, 310);
            this.klientauzvards.Name = "klientauzvards";
            this.klientauzvards.Size = new System.Drawing.Size(100, 20);
            this.klientauzvards.TabIndex = 8;
            // 
            // klientanumurs
            // 
            this.klientanumurs.Location = new System.Drawing.Point(548, 384);
            this.klientanumurs.Name = "klientanumurs";
            this.klientanumurs.Size = new System.Drawing.Size(100, 20);
            this.klientanumurs.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Klients";
            // 
            // klienta_registresana
            // 
            this.klienta_registresana.Location = new System.Drawing.Point(548, 410);
            this.klienta_registresana.Name = "klienta_registresana";
            this.klienta_registresana.Size = new System.Drawing.Size(109, 23);
            this.klienta_registresana.TabIndex = 11;
            this.klienta_registresana.Text = "Pierakstīt klientu";
            this.klienta_registresana.UseVisualStyleBackColor = true;
            this.klienta_registresana.Click += new System.EventHandler(this.klienta_registresana_Click);
            // 
            // preces_registresana
            // 
            this.preces_registresana.Location = new System.Drawing.Point(167, 386);
            this.preces_registresana.Name = "preces_registresana";
            this.preces_registresana.Size = new System.Drawing.Size(109, 23);
            this.preces_registresana.TabIndex = 17;
            this.preces_registresana.Text = "Reģistrēt preci";
            this.preces_registresana.UseVisualStyleBackColor = true;
            this.preces_registresana.Click += new System.EventHandler(this.preces_registresana_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prece";
            // 
            // precescena
            // 
            this.precescena.Location = new System.Drawing.Point(167, 358);
            this.precescena.Name = "precescena";
            this.precescena.Size = new System.Drawing.Size(100, 20);
            this.precescena.TabIndex = 15;
            // 
            // precesnosaukums
            // 
            this.precesnosaukums.Location = new System.Drawing.Point(167, 310);
            this.precesnosaukums.Name = "precesnosaukums";
            this.precesnosaukums.Size = new System.Drawing.Size(100, 20);
            this.precesnosaukums.TabIndex = 14;
            // 
            // precestilpums
            // 
            this.precestilpums.Location = new System.Drawing.Point(167, 332);
            this.precestilpums.Name = "precestilpums";
            this.precestilpums.Size = new System.Drawing.Size(100, 20);
            this.precestilpums.TabIndex = 13;
            // 
            // precesveids
            // 
            this.precesveids.Location = new System.Drawing.Point(167, 287);
            this.precesveids.Name = "precesveids";
            this.precesveids.Size = new System.Drawing.Size(100, 20);
            this.precesveids.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Veids";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nosaukums";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tilpums";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefona numurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "E-pasts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Uzvārds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(654, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Vārds";
            // 
            // klientsprocedura
            // 
            this.klientsprocedura.Location = new System.Drawing.Point(548, 332);
            this.klientsprocedura.Name = "klientsprocedura";
            this.klientsprocedura.Size = new System.Drawing.Size(100, 20);
            this.klientsprocedura.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Proceduras_ID";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Datu izvade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pakalpojums_pieejamiba
            // 
            this.pakalpojums_pieejamiba.Location = new System.Drawing.Point(349, 284);
            this.pakalpojums_pieejamiba.Name = "pakalpojums_pieejamiba";
            this.pakalpojums_pieejamiba.Size = new System.Drawing.Size(100, 20);
            this.pakalpojums_pieejamiba.TabIndex = 31;
            // 
            // pakalpojums_nosaukums
            // 
            this.pakalpojums_nosaukums.Location = new System.Drawing.Point(349, 310);
            this.pakalpojums_nosaukums.Name = "pakalpojums_nosaukums";
            this.pakalpojums_nosaukums.Size = new System.Drawing.Size(100, 20);
            this.pakalpojums_nosaukums.TabIndex = 32;
            // 
            // pakalpojums_cena
            // 
            this.pakalpojums_cena.Location = new System.Drawing.Point(349, 336);
            this.pakalpojums_cena.Name = "pakalpojums_cena";
            this.pakalpojums_cena.Size = new System.Drawing.Size(100, 20);
            this.pakalpojums_cena.TabIndex = 33;
            // 
            // pakalpojums_pecesid
            // 
            this.pakalpojums_pecesid.Location = new System.Drawing.Point(349, 358);
            this.pakalpojums_pecesid.Name = "pakalpojums_pecesid";
            this.pakalpojums_pecesid.Size = new System.Drawing.Size(100, 20);
            this.pakalpojums_pecesid.TabIndex = 34;
            // 
            // Pakalpojums
            // 
            this.Pakalpojums.AutoSize = true;
            this.Pakalpojums.Location = new System.Drawing.Point(346, 266);
            this.Pakalpojums.Name = "Pakalpojums";
            this.Pakalpojums.Size = new System.Drawing.Size(67, 13);
            this.Pakalpojums.TabIndex = 35;
            this.Pakalpojums.Text = "Pakalpojums";
            this.Pakalpojums.Click += new System.EventHandler(this.label11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Preces id";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(455, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Cena";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(455, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Nosaukums";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(455, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Pieejamība";
            // 
            // pierakstisana_pakalpojums
            // 
            this.pierakstisana_pakalpojums.Location = new System.Drawing.Point(349, 391);
            this.pierakstisana_pakalpojums.Name = "pierakstisana_pakalpojums";
            this.pierakstisana_pakalpojums.Size = new System.Drawing.Size(125, 23);
            this.pierakstisana_pakalpojums.TabIndex = 40;
            this.pierakstisana_pakalpojums.Text = "Reģistrēt pakalpojumu";
            this.pierakstisana_pakalpojums.UseVisualStyleBackColor = true;
            this.pierakstisana_pakalpojums.Click += new System.EventHandler(this.pierakstisana_pakalpojums_Click);
            // 
            // atskaites_izveidosana
            // 
            this.atskaites_izveidosana.Location = new System.Drawing.Point(41, 204);
            this.atskaites_izveidosana.Name = "atskaites_izveidosana";
            this.atskaites_izveidosana.Size = new System.Drawing.Size(75, 23);
            this.atskaites_izveidosana.TabIndex = 41;
            this.atskaites_izveidosana.Text = "Atskaites izveidošana";
            this.atskaites_izveidosana.UseVisualStyleBackColor = true;
            this.atskaites_izveidosana.Click += new System.EventHandler(this.atskaites_izveidosana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atskaites_izveidosana);
            this.Controls.Add(this.pierakstisana_pakalpojums);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Pakalpojums);
            this.Controls.Add(this.pakalpojums_pecesid);
            this.Controls.Add(this.pakalpojums_cena);
            this.Controls.Add(this.pakalpojums_nosaukums);
            this.Controls.Add(this.pakalpojums_pieejamiba);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.klientsprocedura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preces_registresana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precescena);
            this.Controls.Add(this.precesnosaukums);
            this.Controls.Add(this.precestilpums);
            this.Controls.Add(this.precesveids);
            this.Controls.Add(this.klienta_registresana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klientanumurs);
            this.Controls.Add(this.klientauzvards);
            this.Controls.Add(this.klientaepasts);
            this.Controls.Add(this.klientavards);
            this.Controls.Add(this.Savienosanas_test);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Datu ievade";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Savienosanas_test;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox klientavards;
        private System.Windows.Forms.TextBox klientaepasts;
        private System.Windows.Forms.TextBox klientauzvards;
        private System.Windows.Forms.TextBox klientanumurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button klienta_registresana;
        private System.Windows.Forms.Button preces_registresana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precescena;
        private System.Windows.Forms.TextBox precesnosaukums;
        private System.Windows.Forms.TextBox precestilpums;
        private System.Windows.Forms.TextBox precesveids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox klientsprocedura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pakalpojums_pieejamiba;
        private System.Windows.Forms.TextBox pakalpojums_nosaukums;
        private System.Windows.Forms.TextBox pakalpojums_cena;
        private System.Windows.Forms.TextBox pakalpojums_pecesid;
        private System.Windows.Forms.Label Pakalpojums;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button pierakstisana_pakalpojums;
        private System.Windows.Forms.Button atskaites_izveidosana;
    }
}

