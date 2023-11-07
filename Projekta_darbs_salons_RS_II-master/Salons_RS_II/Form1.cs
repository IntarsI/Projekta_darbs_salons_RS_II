using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Salons_RS_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_Connection;

            sqlite_Connection = new SQLiteConnection("Data source = Salons_datubaze(2).db; version = 3; New = True; Compress = True;");
            try
            {
                sqlite_Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaut kas ir aizgajis skibi greizi nepariezi");
            }
            return sqlite_Connection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Savienosanas_test_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_Connection;
            sqlite_Connection = CreateConnection();

            SQLiteCommand sqlite_Command;
            sqlite_Command = sqlite_Connection.CreateCommand();
            sqlite_Command.CommandText = "SELECT * FROM Procedura";
            DataTable sTable;
            SQLiteDataAdapter sqlData = new SQLiteDataAdapter(sqlite_Command);
            using (sTable = new DataTable())
            {
                sqlData.Fill(sTable);
                dataGridView1.DataSource = sTable;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preces_registresana_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(precesveids.Text) && !string.IsNullOrWhiteSpace(precesnosaukums.Text) && !string.IsNullOrWhiteSpace(precestilpums.Text) && !string.IsNullOrWhiteSpace(precescena.Text))
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    // Use parameterized query to avoid SQL injection
                    sqlite_cmd.CommandText = "INSERT INTO Preces (veids, nosaukums, tilpums, cena) VALUES (@veids, @nosaukums, @tilpums, @cena)";
                    sqlite_cmd.Parameters.AddWithValue("@veids", precesveids.Text);
                    sqlite_cmd.Parameters.AddWithValue("@nosaukums", precesnosaukums.Text);
                    sqlite_cmd.Parameters.AddWithValue("@tilpums", precestilpums.Text);
                    sqlite_cmd.Parameters.AddWithValue("@cena", precescena.Text);

                    try
                    {
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void klienta_registresana_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(klientaepasts.Text) && !string.IsNullOrWhiteSpace(klientanumurs.Text) && !string.IsNullOrWhiteSpace(klientauzvards.Text) && !string.IsNullOrWhiteSpace(klientavards.Text))
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    // Use parameterized query to avoid SQL injection
                    sqlite_cmd.CommandText = "INSERT INTO Klients (vards, uzvards, epasts, telefona_numurs, proceduras_ID) VALUES (@vards, @uzvards, @epasts, @telefons, @procedura)";
                    sqlite_cmd.Parameters.AddWithValue("@vards", klientavards.Text);
                    sqlite_cmd.Parameters.AddWithValue("@uzvards", klientauzvards.Text);
                    sqlite_cmd.Parameters.AddWithValue("@epasts", klientaepasts.Text);
                    sqlite_cmd.Parameters.AddWithValue("@telefons", klientanumurs.Text);
                    sqlite_cmd.Parameters.AddWithValue("@procedura", klientsprocedura.Text);
                    try
                    {
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void klientavards_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void pierakstisana_pakalpojums_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pakalpojums_cena.Text) && !string.IsNullOrWhiteSpace(pakalpojums_nosaukums.Text) && !string.IsNullOrWhiteSpace(pakalpojums_pecesid.Text) && !string.IsNullOrWhiteSpace(pakalpojums_pieejamiba.Text))
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    // Use parameterized query to avoid SQL injection
                    sqlite_cmd.CommandText = "INSERT INTO Procedura (Preces_ID, Nosaukums, Cena, Pieejamiba) VALUES (@precesid, @nosaukums, @cena, @pieejamiba)";
                    sqlite_cmd.Parameters.AddWithValue("@precesid", pakalpojums_pecesid.Text);
                    sqlite_cmd.Parameters.AddWithValue("@nosaukums", pakalpojums_nosaukums.Text);
                    sqlite_cmd.Parameters.AddWithValue("@cena", pakalpojums_cena.Text);
                    sqlite_cmd.Parameters.AddWithValue("@pieejamiba", pakalpojums_pieejamiba.Text);
                    try
                    {
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void atskaites_izveidosana_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
