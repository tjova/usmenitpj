using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace usmeni
{
    public partial class Kandidati : Form
    {
        public Kandidati()
        {
            InitializeComponent();
            PrikaziKorisnike();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tjova\Documents\portalbaza.mdf;Integrated Security=True;Connect Timeout=30");


        private void ResetujPodatke()
        {
            KandidatIme.Text = "";
            KandidatPrezime.Text = "";
            KandidatEmail.Text = "";
            KandidatAdresa.Text = "";
            KandidatUsername.Text = "";
            KandidatPassword.Text = "";
        }

        private void PrikaziKorisnike()
        {
            conn.Open();
            string query = "SELECT * FROM Korisnik";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var datas = new DataSet();
            adapter.Fill(datas);
            dataGridView1.DataSource = datas.Tables[0];
            conn.Close();
        }

        private void dugmeSacuvaj_Click(object sender, EventArgs e)
        {
            if (KandidatIme.Text == "Ime" || KandidatPrezime.Text == "Prezime" || KandidatEmail.Text == "Email" || KandidatAdresa.Text == "Adresa" || KandidatUsername.Text == "Username" || KandidatPassword.Text == "Password" ||
                KandidatIme.Text == "" || KandidatPrezime.Text == "" || KandidatEmail.Text == "" || KandidatAdresa.Text == "" || KandidatUsername.Text == "U" || KandidatPassword.Text == "")
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            else
            {
                try
                {
                    int uspeh = 0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Korisnik(Ime, Prezime, Username, Password, Uspeh, Adresa, Email, RID) values(@Ime, @Prezime, @Username, @Password, @KUspeh, @Adresa, @Email, @RID)", conn);
                    cmd.Parameters.AddWithValue("@Ime", KandidatIme.Text);
                    cmd.Parameters.AddWithValue("@Prezime", KandidatPrezime.Text);
                    cmd.Parameters.AddWithValue("@Email", KandidatEmail.Text);
                    cmd.Parameters.AddWithValue("@Adresa", KandidatAdresa.Text);
                    cmd.Parameters.AddWithValue("@Username", KandidatUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", HesiranjePassworda(KandidatPassword.Text));
                    cmd.Parameters.AddWithValue("@KUspeh", uspeh);
                    cmd.Parameters.AddWithValue("@RID", 2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Korisnik je ubacen u bazu");
                    conn.Close();
                    ResetujPodatke();
                    PrikaziKorisnike();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void KandidatAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void KandidatUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void KandidatPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void KandidatPrezime_TextChanged(object sender, EventArgs e)
        {
        }

        private void KandidatEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void dugmeResetuj_Click(object sender, EventArgs e)
        {
            ResetujPodatke();
        }
        int mId = 0;
        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (KandidatIme.Text == "Ime" || KandidatPrezime.Text == "Prezime" || KandidatEmail.Text == "Email" || KandidatAdresa.Text == "Adresa" || KandidatUsername.Text == "Username" || KandidatPassword.Text == "Password" ||
                KandidatIme.Text == "" || KandidatPrezime.Text == "" || KandidatEmail.Text == "" || KandidatAdresa.Text == "" || KandidatUsername.Text == "U" || KandidatPassword.Text == "")
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            else
            {
                try
                {
                    int uspeh = 0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Korisnik SET Ime = @Ime, Prezime = @Prezime, Username = @Username, Password = @Password, Adresa = @Adresa, Email = @Email where Kid = @mId", conn);
                    cmd.Parameters.AddWithValue("@Ime", KandidatIme.Text);
                    cmd.Parameters.AddWithValue("@Prezime", KandidatPrezime.Text);
                    cmd.Parameters.AddWithValue("@Email", KandidatEmail.Text);
                    cmd.Parameters.AddWithValue("@Adresa", KandidatAdresa.Text);
                    cmd.Parameters.AddWithValue("@Username", KandidatUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", KandidatPassword.Text);
                    cmd.Parameters.AddWithValue("@mId", mId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Korisnik je azuriran");
                    conn.Close();
                    ResetujPodatke();
                    PrikaziKorisnike();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            KandidatIme.Text = row.Cells[1].Value.ToString();
            KandidatPrezime.Text = row.Cells[2].Value.ToString();
            KandidatEmail.Text = row.Cells[7].Value.ToString();
            KandidatAdresa.Text = row.Cells[6].Value.ToString();
            KandidatUsername.Text = row.Cells[3].Value.ToString();
            KandidatPassword.Text = row.Cells[4].Value.ToString();

            if (KandidatIme.Text == "")
            {
                mId = 0;
            }
            else
            {
                mId = Convert.ToInt32(row.Cells[0].Value.ToString());
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Pitanja pitanja = new Pitanja();
            pitanja.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Rezultati rez = new Rezultati();
            rez.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private string HesiranjePassworda(string pass)
        {
            using(SHA256 shaH = SHA256.Create())
            {
                byte[] niz = shaH.ComputeHash(Encoding.UTF8.GetBytes(pass));

                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < niz.Length; i++)
                {
                    sb.Append(niz[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
