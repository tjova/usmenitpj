namespace usmeni
{
    partial class Pitanja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pitanja));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            dugmeResetujPitanja = new Button();
            dugmeIzmeniPitanja = new Button();
            pitanjaGrid = new DataGridView();
            dugmeSacuvajPitanja = new Button();
            tacanOdgovor = new TextBox();
            ponudjeno3 = new TextBox();
            ponudjeno2 = new TextBox();
            ponudjeno1 = new TextBox();
            tekstPitanja = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pitanjaGrid).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 566);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(dugmeResetujPitanja);
            panel2.Controls.Add(dugmeIzmeniPitanja);
            panel2.Controls.Add(pitanjaGrid);
            panel2.Controls.Add(dugmeSacuvajPitanja);
            panel2.Controls.Add(tacanOdgovor);
            panel2.Controls.Add(ponudjeno3);
            panel2.Controls.Add(ponudjeno2);
            panel2.Controls.Add(ponudjeno1);
            panel2.Controls.Add(tekstPitanja);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1453, 574);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // dugmeResetujPitanja
            // 
            dugmeResetujPitanja.Location = new Point(12, 517);
            dugmeResetujPitanja.Name = "dugmeResetujPitanja";
            dugmeResetujPitanja.Size = new Size(238, 29);
            dugmeResetujPitanja.TabIndex = 13;
            dugmeResetujPitanja.Text = "Resetuj";
            dugmeResetujPitanja.UseVisualStyleBackColor = true;
            dugmeResetujPitanja.Click += dugmeResetujPitanja_Click;
            // 
            // dugmeIzmeniPitanja
            // 
            dugmeIzmeniPitanja.Location = new Point(10, 469);
            dugmeIzmeniPitanja.Name = "dugmeIzmeniPitanja";
            dugmeIzmeniPitanja.Size = new Size(238, 29);
            dugmeIzmeniPitanja.TabIndex = 12;
            dugmeIzmeniPitanja.Text = "Izmeni";
            dugmeIzmeniPitanja.UseVisualStyleBackColor = true;
            dugmeIzmeniPitanja.Click += dugmeIzmeniPitanja_Click;
            // 
            // pitanjaGrid
            // 
            pitanjaGrid.BackgroundColor = Color.White;
            pitanjaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pitanjaGrid.Location = new Point(285, 63);
            pitanjaGrid.Name = "pitanjaGrid";
            pitanjaGrid.RowHeadersWidth = 51;
            pitanjaGrid.RowTemplate.Height = 29;
            pitanjaGrid.Size = new Size(1044, 483);
            pitanjaGrid.TabIndex = 11;
            pitanjaGrid.CellContentClick += pitanjaGrid_CellContentClick;
            // 
            // dugmeSacuvajPitanja
            // 
            dugmeSacuvajPitanja.Location = new Point(10, 424);
            dugmeSacuvajPitanja.Name = "dugmeSacuvajPitanja";
            dugmeSacuvajPitanja.Size = new Size(238, 29);
            dugmeSacuvajPitanja.TabIndex = 10;
            dugmeSacuvajPitanja.Text = "Sacuvaj";
            dugmeSacuvajPitanja.UseVisualStyleBackColor = true;
            dugmeSacuvajPitanja.Click += dugmeSacuvajPitanja_Click;
            // 
            // tacanOdgovor
            // 
            tacanOdgovor.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tacanOdgovor.Location = new Point(12, 284);
            tacanOdgovor.Name = "tacanOdgovor";
            tacanOdgovor.Size = new Size(238, 27);
            tacanOdgovor.TabIndex = 9;
            tacanOdgovor.Text = "Tacan odgovor";
            // 
            // ponudjeno3
            // 
            ponudjeno3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ponudjeno3.Location = new Point(10, 231);
            ponudjeno3.Name = "ponudjeno3";
            ponudjeno3.Size = new Size(238, 27);
            ponudjeno3.TabIndex = 8;
            ponudjeno3.Text = "Ponudjeno 3";
            // 
            // ponudjeno2
            // 
            ponudjeno2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ponudjeno2.Location = new Point(10, 175);
            ponudjeno2.Name = "ponudjeno2";
            ponudjeno2.Size = new Size(238, 27);
            ponudjeno2.TabIndex = 7;
            ponudjeno2.Text = "Ponudjeno 2";
            // 
            // ponudjeno1
            // 
            ponudjeno1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ponudjeno1.Location = new Point(10, 125);
            ponudjeno1.Name = "ponudjeno1";
            ponudjeno1.Size = new Size(238, 27);
            ponudjeno1.TabIndex = 6;
            ponudjeno1.Text = "Ponudjeno 1";
            // 
            // tekstPitanja
            // 
            tekstPitanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tekstPitanja.Location = new Point(10, 75);
            tekstPitanja.Name = "tekstPitanja";
            tekstPitanja.Size = new Size(238, 27);
            tekstPitanja.TabIndex = 5;
            tekstPitanja.Text = "Tekst pitanja";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(761, 7);
            label2.Name = "label2";
            label2.Size = new Size(108, 38);
            label2.TabIndex = 2;
            label2.Text = "Pitanja";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkMagenta;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1364, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(89, 574);
            panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._47576;
            pictureBox3.Location = new Point(8, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_checklist_icon_computer_icons_management_symbol_clipboard_icon_design_summary_miscellaneous_company_removebg_preview;
            pictureBox1.Location = new Point(11, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2023_08_18_133210_removebg_preview;
            pictureBox2.Location = new Point(8, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Pitanja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 566);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pitanja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pitanjaGrid).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private TextBox tekstPitanja;
        private Label label1;
        private Button dugmeSacuvajPitanja;
        private TextBox tacanOdgovor;
        private TextBox ponudjeno3;
        private TextBox ponudjeno2;
        private TextBox ponudjeno1;
        private DataGridView pitanjaGrid;
        private Button dugmeIzmeniPitanja;
        private PictureBox pictureBox2;
        private Button dugmeResetujPitanja;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}