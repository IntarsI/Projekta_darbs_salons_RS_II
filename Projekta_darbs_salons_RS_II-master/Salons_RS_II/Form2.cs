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
                MessageBox.Show("Kaut kas ir aizgajis skibi greizi nepariezi", ex.Message);
            }
            return sqlite_Connection;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Paradit_datus("Klients",Klientu_izvade_grid);
        }

        private void pakalpojumi_Click(object sender, EventArgs e)
        {
            Paradit_datus("Preces", Precu_izvade_grid);  
        }

        private void pakalpojumuizvade_Click(object sender, EventArgs e)
        {
            Paradit_datus("Procedura", Pakalpojumi_izvade_grid);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Paradit_datus(string tabulas_nosaukums, DataGridView dataGridView)
        {
            SQLiteConnection sqlite_Connection;
            sqlite_Connection = CreateConnection();

            SQLiteCommand sqlite_Command;
            sqlite_Command = sqlite_Connection.CreateCommand();
            sqlite_Command.CommandText = $"SELECT * FROM {tabulas_nosaukums}";
            DataTable sTable;
            SQLiteDataAdapter sqlData = new SQLiteDataAdapter(sqlite_Command);
            using (sTable = new DataTable())
            {
                sqlData.Fill(sTable);
                dataGridView.DataSource = sTable;
            }

        }
    }

    public class DatabaseManager
    {
        private SQLiteConnection sqliteConnection;

        public string databasePath = "Salons_datubaze(2).db";

        public DatabaseManager(string databasePath)
        {
            sqliteConnection = new SQLiteConnection($"Data Source={databasePath};Version=3;New=True;Compress=True;");
        }

        public void OpenConnection()
        {
            try
            {
                sqliteConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the database connection: " + ex.Message);
            }
        }
    }
}