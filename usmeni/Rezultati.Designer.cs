namespace usmeni
{
    partial class Rezultati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezultati));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            rezultatiGrid = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            ekranLogout = new PictureBox();
            ekranKorisnici = new PictureBox();
            ekranPitanja = new PictureBox();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            label5 = new Label();
            KandidaticomboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)rezultatiGrid).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ekranLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ekranKorisnici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ekranPitanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(281, 30);
            label1.TabIndex = 4;
            label1.Text = "Priprema za prijemni ispit";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1221, 7);
            label2.Name = "label2";
            label2.Size = new Size(108, 38);
            label2.TabIndex = 2;
            label2.Text = "Pitanja";
            // 
            // rezultatiGrid
            // 
            rezultatiGrid.BackgroundColor = Color.White;
            rezultatiGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezultatiGrid.Location = new Point(196, 150);
            rezultatiGrid.Name = "rezultatiGrid";
            rezultatiGrid.RowHeadersWidth = 51;
            rezultatiGrid.RowTemplate.Height = 29;
            rezultatiGrid.Size = new Size(1044, 448);
            rezultatiGrid.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(KandidaticomboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(rezultatiGrid);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-22, -52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1475, 628);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkMagenta;
            panel3.Controls.Add(ekranLogout);
            panel3.Controls.Add(ekranKorisnici);
            panel3.Controls.Add(ekranPitanja);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1398, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(77, 628);
            panel3.TabIndex = 19;
            // 
            // ekranLogout
            // 
            ekranLogout.Image = Properties.Resources._47576;
            ekranLogout.Location = new Point(8, 429);
            ekranLogout.Name = "ekranLogout";
            ekranLogout.Size = new Size(57, 55);
            ekranLogout.SizeMode = PictureBoxSizeMode.Zoom;
            ekranLogout.TabIndex = 3;
            ekranLogout.TabStop = false;
            ekranLogout.Click += ekranLogout_Click;
            // 
            // ekranKorisnici
            // 
            ekranKorisnici.Image = Properties.Resources.Screenshot_2023_08_18_133210_removebg_preview;
            ekranKorisnici.Location = new Point(8, 235);
            ekranKorisnici.Name = "ekranKorisnici";
            ekranKorisnici.Size = new Size(57, 55);
            ekranKorisnici.SizeMode = PictureBoxSizeMode.Zoom;
            ekranKorisnici.TabIndex = 2;
            ekranKorisnici.TabStop = false;
            ekranKorisnici.Click += ekranKorisnici_Click;
            // 
            // ekranPitanja
            // 
            ekranPitanja.Image = Properties.Resources.Screenshot_2023_08_18_133526_removebg_preview;
            ekranPitanja.Location = new Point(8, 329);
            ekranPitanja.Name = "ekranPitanja";
            ekranPitanja.Size = new Size(57, 55);
            ekranPitanja.SizeMode = PictureBoxSizeMode.Zoom;
            ekranPitanja.TabIndex = 1;
            ekranPitanja.TabStop = false;
            ekranPitanja.Click += ekranPitanja_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(22, 52);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 43);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(532, 122);
            label7.Name = "label7";
            label7.Size = new Size(405, 25);
            label7.TabIndex = 17;
            label7.Text = "Rezultati koje su korisnici platforme do sada ostvarili";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1227, 65);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 16;
            label5.Text = "Filtrirajte rezultate";
            // 
            // KandidaticomboBox1
            // 
            KandidaticomboBox1.FormattingEnabled = true;
            KandidaticomboBox1.Location = new Point(1227, 96);
            KandidaticomboBox1.Name = "KandidaticomboBox1";
            KandidaticomboBox1.Size = new Size(151, 28);
            KandidaticomboBox1.TabIndex = 15;
            KandidaticomboBox1.Text = "Kandidati";
            KandidaticomboBox1.SelectionChangeCommitted += KandidaticomboBox1_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(75, 60);
            label4.Name = "label4";
            label4.Size = new Size(203, 30);
            label4.TabIndex = 14;
            label4.Text = "Nastavnicki portal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(653, 61);
            label6.Name = "label6";
            label6.Size = new Size(132, 38);
            label6.TabIndex = 12;
            label6.Text = "Rezultati";
            // 
            // Rezultati
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 574);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rezultati";
            Text = "Rezultati";
            ((System.ComponentModel.ISupportInitialize)rezultatiGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ekranLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)ekranKorisnici).EndInit();
            ((System.ComponentModel.ISupportInitialize)ekranPitanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridView rezultatiGrid;
        private Panel panel2;
        private Label label4;
        private Label label6;
        private ComboBox KandidaticomboBox1;
        private Label label5;
        private Label label7;
        private PictureBox pictureBox8;
        private Panel panel3;
        private PictureBox ekranLogout;
        private PictureBox ekranKorisnici;
        private PictureBox ekranPitanja;
    }
}