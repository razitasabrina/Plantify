namespace plantify.Forms
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            lblJudul = new Label();
            lblNama = new Label();
            txtNama = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblKonfirm = new Label();
            txtKonfirmPassword = new TextBox();
            lblAlamat = new Label();
            txtAlamat = new TextBox();
            lblNoHp = new Label();
            txtNoHp = new TextBox();
            btnDaftar = new Button();
            btnKeLogin = new Button();
            lblError = new Label();
            lblTanyaRegister = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(75, 96, 67);
            lblJudul.Location = new Point(416, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(207, 35);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Daftar Akun";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(251, 43);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(109, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(251, 67);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(515, 27);
            txtNama.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(251, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(251, 212);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(251, 235);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(515, 27);
            txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(251, 271);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(251, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(239, 27);
            txtPassword.TabIndex = 8;
            // 
            // lblKonfirm
            // 
            lblKonfirm.AutoSize = true;
            lblKonfirm.Location = new Point(535, 271);
            lblKonfirm.Name = "lblKonfirm";
            lblKonfirm.Size = new Size(145, 20);
            lblKonfirm.TabIndex = 9;
            lblKonfirm.Text = "Konfirmasi Password";
            // 
            // txtKonfirmPassword
            // 
            txtKonfirmPassword.Location = new Point(535, 294);
            txtKonfirmPassword.Name = "txtKonfirmPassword";
            txtKonfirmPassword.PasswordChar = '*';
            txtKonfirmPassword.Size = new Size(231, 27);
            txtKonfirmPassword.TabIndex = 10;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(251, 157);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(57, 20);
            lblAlamat.TabIndex = 11;
            lblAlamat.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(251, 180);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(515, 27);
            txtAlamat.TabIndex = 12;
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(535, 101);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(55, 20);
            lblNoHp.TabIndex = 13;
            lblNoHp.Text = "No. HP";
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(535, 126);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(231, 27);
            txtNoHp.TabIndex = 14;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(75, 96, 67);
            btnDaftar.BackgroundImageLayout = ImageLayout.None;
            btnDaftar.FlatAppearance.BorderColor = Color.FromArgb(75, 96, 67);
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDaftar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDaftar.FlatStyle = FlatStyle.Popup;
            btnDaftar.ForeColor = Color.White;
            btnDaftar.Location = new Point(574, 347);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(192, 44);
            btnDaftar.TabIndex = 15;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnKeLogin
            // 
            btnKeLogin.FlatAppearance.BorderSize = 0;
            btnKeLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeLogin.FlatStyle = FlatStyle.Flat;
            btnKeLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeLogin.ForeColor = Color.FromArgb(75, 96, 67);
            btnKeLogin.Location = new Point(693, 394);
            btnKeLogin.Name = "btnKeLogin";
            btnKeLogin.Size = new Size(81, 29);
            btnKeLogin.TabIndex = 16;
            btnKeLogin.Text = "Masuk";
            btnKeLogin.UseVisualStyleBackColor = true;
            btnKeLogin.Click += btnKeLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(574, 425);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 17;
            // 
            // lblTanyaRegister
            // 
            lblTanyaRegister.AutoSize = true;
            lblTanyaRegister.Location = new Point(568, 398);
            lblTanyaRegister.Name = "lblTanyaRegister";
            lblTanyaRegister.Size = new Size(136, 20);
            lblTanyaRegister.TabIndex = 18;
            lblTanyaRegister.Text = "Sudah punya akun?";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(-108, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 458);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Plantify.Properties.Resources.a7e06774_5e62_4ee1_a088_40968eabf182;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(238, 343);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblTanyaRegister);
            Controls.Add(lblError);
            Controls.Add(btnKeLogin);
            Controls.Add(btnDaftar);
            Controls.Add(txtNoHp);
            Controls.Add(lblNoHp);
            Controls.Add(txtAlamat);
            Controls.Add(lblAlamat);
            Controls.Add(txtKonfirmPassword);
            Controls.Add(lblKonfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNama);
            Controls.Add(lblNama);
            Controls.Add(lblJudul);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblKonfirm;
        private TextBox txtKonfirmPassword;
        private Label lblAlamat;
        private TextBox txtAlamat;
        private Label lblNoHp;
        private TextBox txtNoHp;
        private Button btnDaftar;
        private Button btnKeLogin;
        private Label lblError;
        private Label lblTanyaRegister;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}