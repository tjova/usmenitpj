namespace usmeni
{
    partial class Kandidati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kandidati));
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            KandidatPassword = new TextBox();
            dugmeResetuj = new Button();
            KandidatUsername = new TextBox();
            dugmeIzmeni = new Button();
            dataGridView1 = new DataGridView();
            dugmeSacuvaj = new Button();
            KandidatAdresa = new TextBox();
            KandidatEmail = new TextBox();
            KandidatPrezime = new TextBox();
            KandidatIme = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkMagenta;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1357, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(76, 566);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(KandidatPassword);
            panel2.Controls.Add(dugmeResetuj);
            panel2.Controls.Add(KandidatUsername);
            panel2.Controls.Add(dugmeIzmeni);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(dugmeSacuvaj);
            panel2.Controls.Add(KandidatAdresa);
            panel2.Controls.Add(KandidatEmail);
            panel2.Controls.Add(KandidatPrezime);
            panel2.Controls.Add(KandidatIme);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-1, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1433, 566);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // KandidatPassword
            // 
            KandidatPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            KandidatPassword.Location = new Point(10, 296);
            KandidatPassword.Name = "KandidatPassword";
            KandidatPassword.Size = new Size(238, 27);
            KandidatPassword.TabIndex = 16;
            KandidatPassword.Text = "Password";
            KandidatPassword.TextChanged += KandidatPassword_TextChanged;
            // 
            // dugmeResetuj
            // 
            dugmeResetuj.Location = new Point(10, 517);
            dugmeResetuj.Name = "dugmeResetuj";
            dugmeResetuj.Size = new Size(238, 29);
            dugmeResetuj.TabIndex = 15;
            dugmeResetuj.Text = "Resetuj";
            dugmeResetuj.UseVisualStyleBackColor = true;
            dugmeResetuj.Click += dugmeResetuj_Click;
            // 
            // KandidatUsername
            // 
            KandidatUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            KandidatUsername.Location = new Point(10, 252);
            KandidatUsername.Name = "KandidatUsername";
            KandidatUsername.Size = new Size(238, 27);
            KandidatUsername.TabIndex = 13;
            KandidatUsername.Text = "Username";
            KandidatUsername.TextChanged += KandidatUsername_TextChanged;
            // 
            // dugmeIzmeni
            // 
            dugmeIzmeni.Location = new Point(10, 471);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(238, 29);
            dugmeIzmeni.TabIndex = 12;
            dugmeIzmeni.Text = "Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = true;
            dugmeIzmeni.Click += dugmeIzmeni_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(285, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1044, 483);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dugmeSacuvaj
            // 
            dugmeSacuvaj.Location = new Point(10, 424);
            dugmeSacuvaj.Name = "dugmeSacuvaj";
            dugmeSacuvaj.Size = new Size(238, 29);
            dugmeSacuvaj.TabIndex = 10;
            dugmeSacuvaj.Text = "Sacuvaj";
            dugmeSacuvaj.UseVisualStyleBackColor = true;
            dugmeSacuvaj.Click += dugmeSacuvaj_Click;
            // 
            // KandidatAdresa
            // 
            KandidatAdresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            KandidatAdresa.Location = new Point(10, 208);
            KandidatAdresa.Name = "KandidatAdresa";
            KandidatAdresa.Size = new Size(238, 27);
            KandidatAdresa.TabIndex = 8;
            KandidatAdresa.Text = "Adresa";
            KandidatAdresa.TextChanged += KandidatAdresa_TextChanged;
            // 
            // KandidatEmail
            // 
            KandidatEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            KandidatEmail.Location = new Point(10, 165);
            KandidatEmail.Name = "KandidatEmail";
            KandidatEmail.Size = new Size(238, 27);
            KandidatEmail.TabIndex = 7;
            KandidatEmail.Text = "Email";
            KandidatEmail.TextChanged += KandidatEmail_TextChanged;
            // 
            // KandidatPrezime
            // 
            KandidatPrezime.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            KandidatPrezime.Location = new Point(10, 119);
            KandidatPrezime.Name = "KandidatPrezime";
            KandidatPrezime.Size = new Size(238, 27);
            KandidatPrezime.TabIndex = 6;
            KandidatPrezime.Text = "Prezime";
            KandidatPrezime.TextChanged += KandidatPrezime_TextChanged;
            // 
            // KandidatIme
            // 
            KandidatIme.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            KandidatIme.Location = new Point(10, 75);
            KandidatIme.Name = "KandidatIme";
            KandidatIme.Size = new Size(238, 27);
            KandidatIme.TabIndex = 5;
            KandidatIme.Text = "Ime";
            //KandidatIme.TextChanged += KandidatIme_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 7);
            label1.Name = "label1";
            label1.Size = new Size(203, 30);
            label1.TabIndex = 4;
            label1.Text = "Nastavnicki portal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(761, 7);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 3;
            label3.Text = "Kandidati";
            // 
            // Kandidati
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 554);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kandidati";
            Text = "Kandidati";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Button dugmeIzmeni;
        private DataGridView dataGridView1;
        private Button dugmeSacuvaj;
        private TextBox KandidatAdresa;
        private TextBox KandidatEmail;
        private TextBox KandidatPrezime;
        private TextBox KandidatIme;
        private Label label1;
        private Label label3;
        private TextBox KandidatUsername;
        private Button dugmeResetuj;
        private TextBox KandidatPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}