
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace usmeni
{
    public partial class Pitanja : Form
    {
        public Pitanja()
        {
            InitializeComponent();
            PrikaziPitanja();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tjova\Documents\portalbaza.mdf;Integrated Security=True;Connect Timeout=30");
        private void ResetujPodatke()
        {
            tekstPitanja.Text = "";
            ponudjeno1.Text = "";
            ponudjeno2.Text = "";
            ponudjeno3.Text = "";
            tacanOdgovor.Text = "";

        }
        private void PrikaziPitanja()
        {
            conn.Open();
            string query = "SELECT * FROM Pitanje";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            var datas = new DataSet();
            adapter.Fill(datas);
            pitanjaGrid.DataSource = datas.Tables[0];
            conn.Close();
        }
        
        int pId = 0;
        private void pitanjaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = pitanjaGrid.Rows[e.RowIndex];

            tekstPitanja.Text = row.Cells[1].Value.ToString();
            ponudjeno1.Text = row.Cells[2].Value.ToString();
            ponudjeno2.Text = row.Cells[3].Value.ToString();
            ponudjeno3.Text = row.Cells[4].Value.ToString();
            tacanOdgovor.Text = row.Cells[5].Value.ToString();

            if (tekstPitanja.Text == "")
            {
                pId = 0;
            }
            else
            {
                pId = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dugmeSacuvajPitanja_Click(object sender, EventArgs e)
        {
            if (tekstPitanja.Text == "Tekst pitanja" || ponudjeno1.Text == "Ponudjeno 1" || ponudjeno2.Text == "Ponudjeno 2" || ponudjeno3.Text == "Ponudjeno 3" || tacanOdgovor.Text == "Tacan odgovor" ||
                tekstPitanja.Text == "" || ponudjeno1.Text == "" || ponudjeno2.Text == "" || ponudjeno3.Text == "" || tacanOdgovor.Text == "")
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            else
            {
                //Ako su uneseni svi podaci vrsimo ubacivanje u bazu
                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Pitanje(TekstPitanja, Ponudjeno1, Ponudjeno2, Ponudjeno3, Odgovor) values(@TekstPitanja, @Ponudjeno1, @Ponudjeno2, @Ponudjeno3, @Odgovor)", conn);
                    cmd.Parameters.AddWithValue("@TekstPitanja", tekstPitanja.Text);
                    cmd.Parameters.AddWithValue("@Ponudjeno1", ponudjeno1.Text);
                    cmd.Parameters.AddWithValue("@Ponudjeno2", ponudjeno2.Text);
                    cmd.Parameters.AddWithValue("@Ponudjeno3", ponudjeno3.Text);
                    cmd.Parameters.AddWithValue("@Odgovor", tacanOdgovor.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pitanje je dodato u bazu");
                    conn.Close();
                    ResetujPodatke();
                    PrikaziPitanja();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dugmeResetujPitanja_Click(object sender, EventArgs e)
        {
            ResetujPodatke();
        }

        private void dugmeIzmeniPitanja_Click(object sender, EventArgs e)
        {
            if (tekstPitanja.Text == "Tekst pitanja" || ponudjeno1.Text == "Ponudjeno 1" || ponudjeno2.Text == "Ponudjeno 2" || ponudjeno3.Text == "Ponudjeno 3" || tacanOdgovor.Text == "Tacan odgovor" ||
                tekstPitanja.Text == "" || ponudjeno1.Text == "" || ponudjeno2.Text == "" || ponudjeno3.Text == "" || tacanOdgovor.Text == "")
            {
                MessageBox.Show("Niste uneli sve potrebne podatke");
            }
            else
            {
                //Ako su uneseni svi podaci vrsimo izmene u bazi
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Pitanje SET TekstPitanja = @TekstPitanja, Ponudjeno1 = @Ponudjeno1, Ponudjeno2 = @Ponudjeno2, Ponudjeno3 = @Ponudjeno3, Odgovor = @Odgovor where PId = @PId", conn);
                    cmd.Parameters.AddWithValue("@TekstPitanja", tekstPitanja.Text);
                    cmd.Parameters.AddWithValue("@Ponudjeno1", ponudjeno1.Text);
                    cmd.Parameters.AddWithValue("@Ponudjeno2", ponudjeno2.Text);
                    cmd.Parameters.AddWithValue("@Ponudjeno3", ponudjeno3.Text);
                    cmd.Parameters.AddWithValue("@Odgovor", tacanOdgovor.Text);
                    cmd.Parameters.AddWithValue("@PId", pId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pitanje je izmenjeno");
                    conn.Close();
                    ResetujPodatke();
                    PrikaziPitanja();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Kandidati kandidati = new Kandidati();
            kandidati.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Rezultati r = new Rezultati();
            r.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


    }
}