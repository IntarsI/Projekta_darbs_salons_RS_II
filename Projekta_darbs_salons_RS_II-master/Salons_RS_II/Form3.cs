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
using System.IO;

namespace Salons_RS_II
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //izveido konkciju ar datubāzi
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

        private void Izvele_klients_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
            {//atrod nepieciešamo datu lauku no datubāzes
                sqlite_cmd.Parameters.AddWithValue("@vards", klientaid.Text);
                sqlite_cmd.CommandText = "SELECT * FROM Klients WHERE Vards = @vards";

                try
                {
                    using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                    {
                        if (sqlite_datareader.Read())
                        {
                            //iegūst datus no datubāzes 
                            string vards = sqlite_datareader["Vards"].ToString();
                            string uzvards = sqlite_datareader["Uzvards"].ToString();
                            string epasts = sqlite_datareader["epasts"].ToString();
                            richTextBox1.Text += vards+ " " + uzvards+" " + epasts;

                        }
                        else
                        {
                            MessageBox.Show("Nav atrasta rinda datubāzē.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pakalpojuma_izvele_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
            {
                //atrod nepieciešamo datu lauku no datubāzes
                sqlite_cmd.Parameters.AddWithValue("@nosaukums", pakalpojumaid.Text);
                sqlite_cmd.CommandText = "SELECT * FROM Procedura WHERE Nosaukums = @nosaukums";

                try
                {
                    using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                    {
                        if (sqlite_datareader.Read())
                        {
                            //iegūst datus no datubāzes 
                            string nosaukums = sqlite_datareader["Nosaukums"].ToString();
                            string cena = sqlite_datareader["Cena"].ToString();
                            richTextBox1.Text += " " + nosaukums+" " + cena;

                        }
                        else
                        {
                            MessageBox.Show("Nav atrasta rinda datubāzē.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //izveido čeka txt failu
        private void Ceks_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    string filePath = saveFileDialog.FileName;

                    
                    string richTextBoxText = richTextBox1.Text;

                    
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(richTextBoxText);
                    }

                    MessageBox.Show("Saglabāts veiksmīgi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
