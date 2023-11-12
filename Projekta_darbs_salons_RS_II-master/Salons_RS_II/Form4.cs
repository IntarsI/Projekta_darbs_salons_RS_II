using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Salons_RS_II
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //konektētas ar datubāzi
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
                MessageBox.Show("Kaut kas ir aizgajis skibi greizi nepariezi" + ex.Message);
            }
            return sqlite_Connection;
        }

        private void klienta_registresana_Click_1(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrWhiteSpace(klientaepasts.Text) && !string.IsNullOrWhiteSpace(klientanumurs.Text) && !string.IsNullOrWhiteSpace(klientauzvards.Text) && !string.IsNullOrWhiteSpace(klientavards.Text))
                {
                    string laiks = Laika_izvele.Value.ToString("HH:mm");
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();

                    using (SQLiteCommand checkCmd = new SQLiteCommand("SELECT laiks, proceduras_ID FROM Klients WHERE laiks = @laiks OR proceduras_ID = @procedura", sqlite_conn))
                    {
                        checkCmd.Parameters.AddWithValue("@laiks", laiks);
                        checkCmd.Parameters.AddWithValue("@procedura", klientsprocedura.Text);

                        using (SQLiteDataReader reader = checkCmd.ExecuteReader())
                        {//pārbauda vai laiks ir pieejams
                            if (reader.Read())
                            {
                                string existingLaiks = reader["laiks"].ToString();
                                string existingProceduraID = reader["proceduras_ID"].ToString();

                                if (existingProceduraID == klientsprocedura.Text && existingLaiks == laiks)
                                {
                                    MessageBox.Show("Procedūra šajā laikā aizņemta!");
                                }

                                return; 
                            }
                        }
                    }
                    //ievada visus datus datubāzē
                    using (SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO Klients (vards, uzvards, epasts, telefona_numurs, proceduras_ID, Laiks) VALUES (@vards, @uzvards, @epasts, @telefons, @procedura, @Laiks)", sqlite_conn))
                    {
                        insertCmd.Parameters.AddWithValue("@vards", klientavards.Text);
                        insertCmd.Parameters.AddWithValue("@uzvards", klientauzvards.Text);
                        insertCmd.Parameters.AddWithValue("@epasts", klientaepasts.Text);
                        insertCmd.Parameters.AddWithValue("@telefons", klientanumurs.Text);
                        insertCmd.Parameters.AddWithValue("@procedura", klientsprocedura.Text);
                        insertCmd.Parameters.AddWithValue("@Laiks", laiks);

                        try
                        {
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Dati ievaditi veiksmigi.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }


        private void pierakstisana_pakalpojums_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pakalpojums_cena.Text) && !string.IsNullOrWhiteSpace(pakalpojums_nosaukums.Text) && !string.IsNullOrWhiteSpace(pakalpojums_pecesid.Text) && !string.IsNullOrWhiteSpace(pakalpojums_pieejamiba.Text))
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                //ievada visus jaunās procedūras datus datubāzē
                using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    sqlite_cmd.CommandText = "INSERT INTO Procedura (Preces_ID, Nosaukums, Cena, Pieejamiba) VALUES (@precesid, @nosaukums, @cena, @pieejamiba)";
                    sqlite_cmd.Parameters.AddWithValue("@precesid", pakalpojums_pecesid.Text);
                    sqlite_cmd.Parameters.AddWithValue("@nosaukums", pakalpojums_nosaukums.Text);
                    sqlite_cmd.Parameters.AddWithValue("@cena", pakalpojums_cena.Text);
                    sqlite_cmd.Parameters.AddWithValue("@pieejamiba", pakalpojums_pieejamiba.Text);
                    try
                    {
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("Dati ievadīti veiksmīgi");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aizpildiet visus laukus.");
            }
        }

        private void preces_registresana_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(precesveids.Text) && !string.IsNullOrWhiteSpace(precesnosaukums.Text) && !string.IsNullOrWhiteSpace(precestilpums.Text) && !string.IsNullOrWhiteSpace(precescena.Text))
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                //ievada jaunās preces datus datubāzē
                using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    sqlite_cmd.CommandText = "INSERT INTO Preces (veids, nosaukums, tilpums, cena) VALUES (@veids, @nosaukums, @tilpums, @cena)";
                    sqlite_cmd.Parameters.AddWithValue("@veids", precesveids.Text);
                    sqlite_cmd.Parameters.AddWithValue("@nosaukums", precesnosaukums.Text);
                    sqlite_cmd.Parameters.AddWithValue("@tilpums", precestilpums.Text);
                    sqlite_cmd.Parameters.AddWithValue("@cena", precescena.Text);

                    try
                    {
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("Dati ievaditi veiksmigi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aizpildiet visus laukus.");
            }
        }

        private void klientsprocedura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

