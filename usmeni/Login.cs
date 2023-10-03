using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usmeni
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tjova\Documents\bazasajt.mdf;Integrated Security=True;Connect Timeout=30");

        public static string KorisnikUser = "";
        public static int trazeniKorisnikId = 0;
        public static int idRoleKorisnika = 0;
        private void prijavaDugme_Click(object sender, EventArgs e)
        {
            if (usernameUnos.Text == "" || passUnos.Text == "")
            {
                MessageBox.Show("Unesite podatke");
            }
            else
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM Korisnik WHERE Password = '" + passUnos.Text + "' and Username='" + usernameUnos.Text + "'", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows[0][0].ToString() == "1")
                {
                    KorisnikUser = usernameUnos.Text;

                    SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Korisnik WHERE Password = '" + passUnos.Text + "' and Username='" + usernameUnos.Text + "'", conn);
                    DataTable table2 = new DataTable();
                    adapter2.Fill(table2);

                    foreach (DataRow row in table2.Rows)
                    {
                        trazeniKorisnikId = (int)row["KId"];
                        idRoleKorisnika = (int)row["RID"];
                    }

                    if (idRoleKorisnika == 1)
                    {
                        Kandidati kandidati = new Kandidati();
                        kandidati.Show();
                        this.Hide();
                        conn.Close();
                    }
                    else
                    {
                        Test test = new Test();
                        test.Show();
                        this.Hide();
                        conn.Close();
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Ne postoji korisnik sa ovim podacima u bazi");
                }
                conn.Close();
            }
        }

        private string HesiranjePassworda(string pass)
        {
            using (SHA256 shaH = SHA256.Create())
            {
                byte[] niz = shaH.ComputeHash(Encoding.UTF8.GetBytes(pass));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < niz.Length; i++)
                {
                    sb.Append(niz[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
