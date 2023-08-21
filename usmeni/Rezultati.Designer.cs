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
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            label5 = new Label();
            KandidaticomboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)rezultatiGrid).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            rezultatiGrid.CellContentClick += rezultatiGrid_CellContentClick;
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
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1398, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(77, 628);
            panel3.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 429);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
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
            KandidaticomboBox1.SelectedIndexChanged += KandidaticomboBox1_SelectedIndexChanged;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}