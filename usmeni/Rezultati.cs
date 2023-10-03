using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usmeni
{
    public partial class Rezultati : Form
    {
        public Rezultati()
        {
            InitializeComponent();
            prikaziKorisnike();
            PrikaziRezultate();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tjova\Documents\bazasajt.mdf;Integrated Security=True;Connect Timeout=30");

        private void prikaziKorisnike()
        {
            conn.Open();
            string query = "SELECT Username FROM Korisnik WHERE RID <> 1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            KandidaticomboBox1.ValueMember = "Username";
            KandidaticomboBox1.DataSource = table;
            conn.Close();
        }
        private void PrikaziRezultate()
        {
            conn.Open();
            string query = "SELECT * FROM Testiranje";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var datas = new DataSet();
            adapter.Fill(datas);
            rezultatiGrid.DataSource = datas.Tables[0];
            conn.Close();
        }

        private void filterKorisnik()
        {
            conn.Open();
            string query = "SELECT * FROM Testiranje INNER JOIN Korisnik ON Korisnik.KId = Testiranje.KandidatID WHERE Korisnik.Username ='" + KandidaticomboBox1.SelectedValue.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var datas = new DataSet();
            adapter.Fill(datas);
            rezultatiGrid.DataSource = datas.Tables[0];
            conn.Close();
        }

        private void KandidaticomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterKorisnik();
        }

        private void ekranKorisnici_Click(object sender, EventArgs e)
        {
            Kandidati kandidati = new Kandidati();
            kandidati.Show();
            this.Hide();
        }

        private void ekranPitanja_Click(object sender, EventArgs e)
        {
            Pitanja pitanja = new Pitanja();
            pitanja.Show();
            this.Hide();
        }

        private void ekranLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
