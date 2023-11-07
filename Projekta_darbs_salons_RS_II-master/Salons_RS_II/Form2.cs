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
    public partial class Form2 : Form
    {
        public Form2()
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
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_Connection;
            sqlite_Connection = CreateConnection();

            SQLiteCommand sqlite_Command;
            sqlite_Command = sqlite_Connection.CreateCommand();
            sqlite_Command.CommandText = "SELECT * FROM Klients";
            DataTable sTable;
            SQLiteDataAdapter sqlData = new SQLiteDataAdapter(sqlite_Command);
            using (sTable = new DataTable())
            {
                sqlData.Fill(sTable);
                dataGridView1.DataSource = sTable;
            }
        }

        private void pakalpojumi_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_Connection;
            sqlite_Connection = CreateConnection();

            SQLiteCommand sqlite_Command;
            sqlite_Command = sqlite_Connection.CreateCommand();
            sqlite_Command.CommandText = "SELECT * FROM Preces";
            DataTable sTable;
            SQLiteDataAdapter sqlData = new SQLiteDataAdapter(sqlite_Command);
            using (sTable = new DataTable())
            {
                sqlData.Fill(sTable);
                izvadeslauks.DataSource = sTable;
            }
        }

        private void pakalpojumuizvade_Click(object sender, EventArgs e)
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
                dataGridView2.DataSource = sTable;
            }
        }
    }
}
