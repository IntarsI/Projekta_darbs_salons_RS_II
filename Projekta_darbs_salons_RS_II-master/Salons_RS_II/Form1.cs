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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Datu_ievade_Click(object sender, EventArgs e)
        {
            Form4 datu_ievade = new Form4();
            datu_ievade.Show();
        }

        private void Dati_no_DB_Click(object sender, EventArgs e)
        {
            Form2 datu_paradisana = new Form2();
            datu_paradisana.Show();
        }

        private void Ceka_izvede_Click(object sender, EventArgs e)
        {
            Form3 ceka_izveide = new Form3();
            ceka_izveide.Show();
        }
    }
}
