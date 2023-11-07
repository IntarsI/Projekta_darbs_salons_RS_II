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
            {
                sqlite_cmd.Parameters.AddWithValue("@vards", klientaid.Text);
                sqlite_cmd.CommandText = "SELECT * FROM Klients WHERE Vards = @vards";

                try
                {
                    using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                    {
                        if (sqlite_datareader.Read())
                        {
                            // Retrieve data from the selected row
                            string vards = sqlite_datareader["Vards"].ToString();
                            string uzvards = sqlite_datareader["Uzvards"].ToString();
                            string epasts = sqlite_datareader["epasts"].ToString();
                            richTextBox1.Text += vards+ " " + uzvards+" " + epasts;

                            // You can use these values as needed
                        }
                        else
                        {
                            MessageBox.Show("No rows found in the database.");
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
                // Use a SELECT statement with a LIMIT 1 to get only one row
                sqlite_cmd.Parameters.AddWithValue("@nosaukums", pakalpojumaid.Text);
                sqlite_cmd.CommandText = "SELECT * FROM Procedura WHERE Nosaukums = @nosaukums";

                try
                {
                    using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                    {
                        if (sqlite_datareader.Read())
                        {
                            // Retrieve data from the selected row
                            string nosaukums = sqlite_datareader["Nosaukums"].ToString();
                            string cena = sqlite_datareader["Cena"].ToString();
                            richTextBox1.Text += " " + nosaukums+" " + cena;

                        }
                        else
                        {
                            MessageBox.Show("No rows found in the database.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Ceks_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the path of the selected file
                    string filePath = saveFileDialog.FileName;

                    // Get the text from your RichTextBox
                    string richTextBoxText = richTextBox1.Text;

                    // Write the text to the selected file
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(richTextBoxText);
                    }

                    MessageBox.Show("Text saved to file successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
