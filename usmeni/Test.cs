using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;
using Font = iTextSharp.text.Font;


namespace usmeni
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            korisnikLabel.Text = Login.KorisnikUser;

            brojP = brojPitanja();

            prikaziPitanja();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            progressBar1.Value = 0;

            timer1.Start();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tjova\Documents\bazasajt.mdf;Integrated Security=True;Connect Timeout=30");

        int brojP;
        private int brojPitanja()
        {
            int brPit;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM Pitanje", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            brPit = Convert.ToInt32(table.Rows[0][0]);
            conn.Close();
            return brPit;
        }

        int[] indeksi = new int[10];
        private void randomPitanja()
        {
            HashSet<int> brojevi = new HashSet<int>();

            var random = new Random();

            while (brojevi.Count < 10)
            {
                brojevi.Add(random.Next(15, 15 + brojP - 1));
            }

            for (int i = 0; i < 10; i++)
            {
                indeksi[i] = brojevi.ElementAt(i);
            }

        }

        private void RendomListRedosled(List<string> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        String o1;
        String o2;
        String o3;
        String o4;
        String o5;
        String o6;
        String o7;
        String o8;
        String o9;
        String o10;

        List<String> listaTacniOdg = new List<String>();

        String tPitanja1;
        String tPitanja2;
        String tPitanja3;
        String tPitanja4;
        String tPitanja5;
        String tPitanja6;
        String tPitanja7;
        String tPitanja8;
        String tPitanja9;
        String tPitanja10;

        List<String> listaTPitanja = new List<String>();

        private void prikaziPitanja()
        {
            try
            {
                randomPitanja();
                conn.Open();

                string query = "SELECT * FROM Pitanje where PId = " + indeksi[0] + "";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                List<string> redovi = new List<string>();


                foreach (DataRow row in table.Rows)
                {
                    tPitanja1 = row["TekstPitanja"].ToString();
                    pitanje1.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o1 = row["Odgovor"].ToString();

                    redovi.Add(p12);
                    redovi.Add(p13);
                    redovi.Add(p14);
                    redovi.Add(p15);
                }

                RendomListRedosled(redovi);

                p1p1.Text = redovi[0];
                p1p2.Text = redovi[1];
                p1p3.Text = redovi[2];
                p1p4.Text = redovi[3];

                string query1 = "SELECT * FROM Pitanje where PId = " + indeksi[1] + "";
                adapter = new SqlDataAdapter(query1, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi1 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja2 = row["TekstPitanja"].ToString();
                    pitanje2.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o2 = row["Odgovor"].ToString();

                    redovi1.Add(p12);
                    redovi1.Add(p13);
                    redovi1.Add(p14);
                    redovi1.Add(p15);
                }

                RendomListRedosled(redovi1);

                p2p1.Text = redovi1[0];
                p2p2.Text = redovi1[1];
                p2p3.Text = redovi1[2];
                p2p4.Text = redovi1[3];

                string query2 = "SELECT * FROM Pitanje where PId = " + indeksi[2] + "";
                adapter = new SqlDataAdapter(query2, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi2 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja3 = row["TekstPitanja"].ToString();
                    pitanje3.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o3 = row["Odgovor"].ToString();

                    redovi2.Add(p12);
                    redovi2.Add(p13);
                    redovi2.Add(p14);
                    redovi2.Add(p15);
                }

                RendomListRedosled(redovi2);

                p3p1.Text = redovi2[0];
                p3p2.Text = redovi2[1];
                p3p3.Text = redovi2[2];
                p3p4.Text = redovi2[3];

                string query3 = "SELECT * FROM Pitanje where PId = " + indeksi[3] + "";
                adapter = new SqlDataAdapter(query3, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi3 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja4 = row["TekstPitanja"].ToString();
                    pitanje4.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o4 = row["Odgovor"].ToString();

                    redovi3.Add(p12);
                    redovi3.Add(p13);
                    redovi3.Add(p14);
                    redovi3.Add(p15);
                }

                RendomListRedosled(redovi3);

                p4p1.Text = redovi3[0];
                p4p2.Text = redovi3[1];
                p4p3.Text = redovi3[2];
                p4p4.Text = redovi3[3];

                string query4 = "SELECT * FROM Pitanje where PId = " + indeksi[4] + "";
                adapter = new SqlDataAdapter(query4, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi4 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja5 = row["TekstPitanja"].ToString();
                    pitanje5.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o5 = row["Odgovor"].ToString();

                    redovi4.Add(p12);
                    redovi4.Add(p13);
                    redovi4.Add(p14);
                    redovi4.Add(p15);
                }

                RendomListRedosled(redovi4);

                p5p1.Text = redovi4[0];
                p5p2.Text = redovi4[1];
                p5p3.Text = redovi4[2];
                p5p4.Text = redovi4[3];

                string query5 = "SELECT * FROM Pitanje where PId = " + indeksi[5] + "";
                adapter = new SqlDataAdapter(query5, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi5 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja6 = row["TekstPitanja"].ToString();
                    pitanje6.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o6 = row["Odgovor"].ToString();

                    redovi5.Add(p12);
                    redovi5.Add(p13);
                    redovi5.Add(p14);
                    redovi5.Add(p15);
                }

                RendomListRedosled(redovi5);

                p6p1.Text = redovi5[0];
                p6p2.Text = redovi5[1];
                p6p3.Text = redovi5[2];
                p6p4.Text = redovi5[3];

                string query6 = "SELECT * FROM Pitanje where PId = " + indeksi[6] + "";
                adapter = new SqlDataAdapter(query6, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi6 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja7 = row["TekstPitanja"].ToString();
                    pitanje7.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o7 = row["Odgovor"].ToString();

                    redovi6.Add(p12);
                    redovi6.Add(p13);
                    redovi6.Add(p14);
                    redovi6.Add(p15);
                }

                RendomListRedosled(redovi6);

                p7p1.Text = redovi6[0];
                p7p2.Text = redovi6[1];
                p7p3.Text = redovi6[2];
                p7p4.Text = redovi6[3];

                string query7 = "SELECT * FROM Pitanje where PId = " + indeksi[7] + "";
                adapter = new SqlDataAdapter(query7, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi7 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja8 = row["TekstPitanja"].ToString();
                    pitanje8.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o8 = row["Odgovor"].ToString();

                    redovi7.Add(p12);
                    redovi7.Add(p13);
                    redovi7.Add(p14);
                    redovi7.Add(p15);
                }

                RendomListRedosled(redovi7);

                p8p1.Text = redovi7[0];
                p8p2.Text = redovi7[1];
                p8p3.Text = redovi7[2];
                p8p4.Text = redovi7[3];

                string query8 = "SELECT * FROM Pitanje where PId = " + indeksi[8] + "";
                adapter = new SqlDataAdapter(query8, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi8 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja9 = row["TekstPitanja"].ToString();
                    pitanje9.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o9 = row["Odgovor"].ToString();

                    redovi8.Add(p12);
                    redovi8.Add(p13);
                    redovi8.Add(p14);
                    redovi8.Add(p15);
                }

                RendomListRedosled(redovi8);

                p9p1.Text = redovi8[0];
                p9p2.Text = redovi8[1];
                p9p3.Text = redovi8[2];
                p9p4.Text = redovi8[3];

                string query9 = "SELECT * FROM Pitanje where PId = " + indeksi[9] + "";
                adapter = new SqlDataAdapter(query9, conn);
                table = new DataTable();
                adapter.Fill(table);
                List<string> redovi9 = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    tPitanja10 = row["TekstPitanja"].ToString();
                    pitanje10.Text = row["TekstPitanja"].ToString();
                    string p12 = row["Ponudjeno1"].ToString();
                    string p13 = row["Ponudjeno2"].ToString();
                    string p14 = row["Ponudjeno3"].ToString();
                    string p15 = row["Odgovor"].ToString();
                    o10 = row["Odgovor"].ToString();

                    redovi9.Add(p12);
                    redovi9.Add(p13);
                    redovi9.Add(p14);
                    redovi9.Add(p15);
                }

                RendomListRedosled(redovi9);

                p10p1.Text = redovi9[0];
                p10p2.Text = redovi9[1];
                p10p3.Text = redovi9[2];
                p10p4.Text = redovi9[3];


                listaTPitanja.Add(tPitanja1);
                listaTPitanja.Add(tPitanja2);
                listaTPitanja.Add(tPitanja3);
                listaTPitanja.Add(tPitanja4);
                listaTPitanja.Add(tPitanja5);
                listaTPitanja.Add(tPitanja6);
                listaTPitanja.Add(tPitanja7);
                listaTPitanja.Add(tPitanja8);
                listaTPitanja.Add(tPitanja9);
                listaTPitanja.Add(tPitanja10);

                listaTacniOdg.Add(o1);
                listaTacniOdg.Add(o2);
                listaTacniOdg.Add(o3);
                listaTacniOdg.Add(o4);
                listaTacniOdg.Add(o5);
                listaTacniOdg.Add(o6);
                listaTacniOdg.Add(o7);
                listaTacniOdg.Add(o8);
                listaTacniOdg.Add(o9);
                listaTacniOdg.Add(o10);

                generisiIzvestajPitanja(listaTPitanja);

                conn.Close();

            }
            catch (Exception ex)
            {

            }


        }


        int poeni = 0;

        string[] odgovori = new string[10];
        List<int> tacni = new List<int>();

        private void ProveraPrvoPitanje()
        {
            if (p1p1.Checked)
            {
                odgovori[0] = "";
                odgovori[0] = p1p1.Text;
            }
            else if (p1p2.Checked)
            {
                odgovori[0] = "";
                odgovori[0] = p1p2.Text;
            }
            else if (p1p3.Checked)
            {
                odgovori[0] = "";
                odgovori[0] = p1p3.Text;
            }
            else if (p1p4.Checked)
            {
                odgovori[0] = "";
                odgovori[0] = p1p4.Text;
            }

            if (odgovori[0] == o1)
            {
                poeni += 1;
                tacni.Add(1);
            }
        }

        private void ProveraDrugoPitanje()
        {
            if (p2p1.Checked)
            {
                odgovori[1] = "";
                odgovori[1] = p2p1.Text;
            }
            else if (p2p2.Checked)
            {
                odgovori[1] = "";
                odgovori[1] = p2p2.Text;
            }
            else if (p2p3.Checked)
            {
                odgovori[1] = "";
                odgovori[1] = p2p3.Text;
            }
            else if (p2p4.Checked)
            {
                odgovori[1] = "";
                odgovori[1] = p2p4.Text;
            }

            if (odgovori[1] == o2)
            {
                poeni += 1;
                tacni.Add(2);
            }

        }

        private void ProveraTrecePitanje()
        {
            if (p3p1.Checked)
            {
                odgovori[2] = "";
                odgovori[2] = p3p1.Text;
            }
            else if (p3p2.Checked)
            {
                odgovori[2] = "";
                odgovori[2] = p3p2.Text;
            }
            else if (p3p3.Checked)
            {
                odgovori[2] = "";
                odgovori[2] = p3p3.Text;
            }
            else if (p2p4.Checked)
            {
                odgovori[2] = "";
                odgovori[2] = p3p4.Text;
            }

            if (odgovori[2] == o3)
            {
                poeni += 1;
                tacni.Add(3);
            }

        }

        private void ProveraCetvrtoPitanje()
        {
            if (p4p1.Checked)
            {
                odgovori[3] = "";
                odgovori[3] = p4p1.Text;
            }
            else if (p4p2.Checked)
            {
                odgovori[3] = "";
                odgovori[3] = p4p2.Text;
            }
            else if (p4p3.Checked)
            {
                odgovori[3] = "";
                odgovori[3] = p4p3.Text;
            }
            else if (p4p4.Checked)
            {
                odgovori[3] = "";
                odgovori[3] = p4p4.Text;
            }

            if (odgovori[3] == o4)
            {
                poeni += 1;
                tacni.Add(4);
            }

        }
        private void ProveraPetoPitanje()
        {
            if (p5p1.Checked)
            {
                odgovori[4] = "";
                odgovori[4] = p5p1.Text;
            }
            else if (p5p2.Checked)
            {
                odgovori[4] = "";
                odgovori[4] = p5p2.Text;
            }
            else if (p5p3.Checked)
            {
                odgovori[4] = "";
                odgovori[4] = p5p3.Text;
            }
            else if (p5p4.Checked)
            {
                odgovori[4] = "";
                odgovori[4] = p5p4.Text;
            }

            if (odgovori[4] == o5)
            {
                poeni += 1;
                tacni.Add(5);
            }

        }
        private void ProveraSestoPitanje()
        {
            if (p6p1.Checked)
            {
                odgovori[5] = "";
                odgovori[5] = p6p1.Text;
            }
            else if (p6p2.Checked)
            {
                odgovori[5] = "";
                odgovori[5] = p6p2.Text;
            }
            else if (p6p3.Checked)
            {
                odgovori[5] = "";
                odgovori[5] = p6p3.Text;
            }
            else if (p6p4.Checked)
            {
                odgovori[5] = "";
                odgovori[5] = p6p4.Text;
            }

            if (odgovori[5] == o6)
            {
                poeni += 1;
                tacni.Add(6);
            }

        }
        private void ProveraSedmoPitanje()
        {
            if (p7p1.Checked)
            {
                odgovori[6] = "";
                odgovori[6] = p7p1.Text;
            }
            else if (p7p2.Checked)
            {
                odgovori[6] = "";
                odgovori[6] = p7p2.Text;
            }
            else if (p7p3.Checked)
            {
                odgovori[6] = "";
                odgovori[6] = p7p3.Text;
            }
            else if (p7p4.Checked)
            {
                odgovori[6] = "";
                odgovori[6] = p7p4.Text;
            }

            if (odgovori[6] == o7)
            {
                poeni += 1;
                tacni.Add(7);
            }

        }
        private void ProveraOsmoPitanje()
        {
            if (p8p1.Checked)
            {
                odgovori[7] = "";
                odgovori[7] = p8p1.Text;
            }
            else if (p8p2.Checked)
            {
                odgovori[7] = "";
                odgovori[7] = p8p2.Text;
            }
            else if (p8p3.Checked)
            {
                odgovori[7] = "";
                odgovori[7] = p8p3.Text;
            }
            else if (p8p4.Checked)
            {
                odgovori[7] = "";
                odgovori[7] = p8p4.Text;
            }

            if (odgovori[7] == o8)
            {
                poeni += 1;
                tacni.Add(8);
            }

        }
        private void ProveraDevetoPitanje()
        {
            if (p9p1.Checked)
            {
                odgovori[8] = "";
                odgovori[8] = p9p1.Text;
            }
            else if (p9p2.Checked)
            {
                odgovori[8] = "";
                odgovori[8] = p9p2.Text;
            }
            else if (p9p3.Checked)
            {
                odgovori[8] = "";
                odgovori[8] = p9p3.Text;
            }
            else if (p9p4.Checked)
            {
                odgovori[8] = "";
                odgovori[8] = p9p4.Text;
            }

            if (odgovori[8] == o9)
            {
                poeni += 1;
                tacni.Add(9);
            }

        }
        private void ProveraDesetoPitanje()
        {
            if (p10p1.Checked)
            {
                odgovori[9] = "";
                odgovori[9] = p10p1.Text;
            }
            else if (p10p2.Checked)
            {
                odgovori[9] = "";
                odgovori[9] = p10p2.Text;
            }
            else if (p10p3.Checked)
            {
                odgovori[9] = "";
                odgovori[9] = p10p3.Text;
            }
            else if (p10p4.Checked)
            {
                odgovori[9] = "";
                odgovori[9] = p10p4.Text;
            }

            if (odgovori[9] == o10)
            {
                poeni += 1;
                tacni.Add(10);
            }

        }

        int brojTestova = 0;
        int ukupanBrPoena = 0;

        private void generisiIzvestajPitanja(List<String> tePitanja)
        {
            Document document = new Document();

            try
            {
                string desktopPutanja = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePutanja = Path.Combine(desktopPutanja, "PitanjaReport.pdf");

                PdfWriter.GetInstance(document, new FileStream(filePutanja, FileMode.Create));
                document.Open();
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font font = new Font(baseFont, 12f);

                string text3 = "Pitanja koja ste dobili na testu i tacni odgovori:";
                document.Add(new Paragraph(text3, font));

                document.Add(new Paragraph("\n"));

                for (int i = 0; i < listaTPitanja.Count; i++)
                {
                    document.Add(new Paragraph(listaTPitanja[i].ToString(), font));
                    document.Add(new Paragraph("\n"));
                    document.Add(new Paragraph(listaTacniOdg[i].ToString(), font));
                    document.Add(new Paragraph("\n"));
                };

                document.Add(new Paragraph("\n"));
            }
            catch (DocumentException de)
            {
                Console.WriteLine("PDF document exception: " + de.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine("IO Exception: " + ioe.Message);
            }
            finally
            {
                document.Close();
            }
        }

        private void generisiIzvestaj(int poeni1, int ukupanBrPoena1, int brojTestova1, string Yourusername)
        {
            Document document = new Document();

            try
            {
                string desktopPutanja = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePutanja = Path.Combine(desktopPutanja, "Report.pdf");

                PdfWriter.GetInstance(document, new FileStream(filePutanja, FileMode.Create));
                document.Open();
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font font = new Font(baseFont, 12f);

                string text3 = "Vas username : " + Yourusername;
                document.Add(new Paragraph(text3, font));

                document.Add(new Paragraph("\n"));

                string text1 = "Broj poena koji ste ostvarili na ovom testu : " + poeni1;
                document.Add(new Paragraph(text1, font));

                string text4 = "Redni broj pitanja na koja ste odgovorili tacno na testu : ";
                document.Add(new Paragraph(text4, font));
                for (int i = 0; i < tacni.Count; i++)
                {
                    document.Add(new Paragraph(tacni[i].ToString(), font));
                };

                document.Add(new Paragraph("\n"));

                int procenat = ukupanBrPoena1 / brojTestova1;

                string text2 = "Vasa uspesnost na testovima do sada : " + procenat + " % ";
                document.Add(new Paragraph(text2, font));
            }
            catch (DocumentException de)
            {
                Console.WriteLine("PDF document exception: " + de.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine("IO Exception: " + ioe.Message);
            }
            finally
            {
                document.Close();
            }
        }

        private void ubaciPodatke()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Testiranje(KandidatID, Datum, Vreme, Poeni) values (@KandidatID, @Datum, @Vreme, @Poeni)", conn);
                cmd.Parameters.AddWithValue("@KandidatID", Login.trazeniKorisnikId);
                cmd.Parameters.AddWithValue("@Datum", datumTesta.Value.Date);
                DateTime tv = datumTesta.Value;
                TimeSpan tacnovreme = tv.TimeOfDay;
                string bazaformat = tacnovreme.ToString("hh\\:mm\\:ss");
                cmd.Parameters.AddWithValue("@Vreme", bazaformat);
                cmd.Parameters.AddWithValue("@Poeni", poeni);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vas rezultat je sacuvan");

                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT COUNT(*) FROM Testiranje WHERE KandidatID = " + Login.trazeniKorisnikId, conn);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                if (table1.Rows[0][0].ToString() != "0")
                {
                    brojTestova = (int)table1.Rows[0][0];
                }

                SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT SUM(Poeni) FROM Testiranje WHERE KandidatID = " + Login.trazeniKorisnikId, conn);
                DataTable table3 = new DataTable();
                adapter3.Fill(table3);

                if (table3.Rows[0][0].ToString() != "0")
                {
                    ukupanBrPoena = (int)table3.Rows[0][0];
                }


                int promena = ukupanBrPoena / brojTestova;


                SqlCommand commandU = new SqlCommand("UPDATE Korisnik SET Uspeh = @Uspeh where KId = " + Login.trazeniKorisnikId, conn);
                commandU.Parameters.AddWithValue("@Uspeh", promena);
                commandU.ExecuteNonQuery();

                generisiIzvestaj(poeni, ukupanBrPoena, brojTestova, Login.KorisnikUser);

                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void predajDugme_Click(object sender, EventArgs e)
        {
            poeni = 0;
            ProveraPrvoPitanje();
            ProveraDrugoPitanje();
            ProveraTrecePitanje();
            ProveraCetvrtoPitanje();
            ProveraPetoPitanje();
            ProveraSestoPitanje();
            ProveraSedmoPitanje();
            ProveraOsmoPitanje();
            ProveraDevetoPitanje();
            ProveraDesetoPitanje();

            MessageBox.Show("Osvojili ste :" + poeni + " poena");
            ubaciPodatke();

            Login noviLog = new Login();
            this.Hide();
            noviLog.Show();
        }

        int brojT = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            brojT++;
            tajmerL.Text = "" + brojT;
            progressBar1.Value++;

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Vreme vam je isteklo!");
                this.Hide();
                Login login = new Login();
            }
        }

    }
}
