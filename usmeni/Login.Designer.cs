namespace usmeni
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            usernameUnos = new TextBox();
            passUnos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            prijavaDugme = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 437);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(6, 403);
            label6.Name = "label6";
            label6.Size = new Size(234, 25);
            label6.TabIndex = 16;
            label6.Text = "Prirodno matematicki fakultet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(11, 215);
            label5.Name = "label5";
            label5.Size = new Size(231, 25);
            label5.TabIndex = 15;
            label5.Text = "za pripremu prijemnog ispita";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(36, 185);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 14;
            label4.Text = "Dobrodosli na portal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(249, 92);
            label3.Name = "label3";
            label3.Size = new Size(106, 38);
            label3.TabIndex = 4;
            label3.Text = "Prijava";
            // 
            // usernameUnos
            // 
            usernameUnos.Location = new Point(249, 189);
            usernameUnos.Name = "usernameUnos";
            usernameUnos.Size = new Size(406, 27);
            usernameUnos.TabIndex = 5;
            // 
            // passUnos
            // 
            passUnos.Location = new Point(249, 259);
            passUnos.Name = "passUnos";
            passUnos.Size = new Size(406, 27);
            passUnos.TabIndex = 6;
            passUnos.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(249, 158);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(249, 228);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // prijavaDugme
            // 
            prijavaDugme.Location = new Point(249, 333);
            prijavaDugme.Name = "prijavaDugme";
            prijavaDugme.Size = new Size(132, 29);
            prijavaDugme.TabIndex = 13;
            prijavaDugme.Text = "Prijavi se";
            prijavaDugme.UseVisualStyleBackColor = true;
            prijavaDugme.Click += prijavaDugme_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(672, 437);
            Controls.Add(prijavaDugme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passUnos);
            Controls.Add(usernameUnos);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox usernameUnos;
        private TextBox passUnos;
        private Label label1;
        private Label label2;
        private Button prijavaDugme;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}