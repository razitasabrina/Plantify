namespace plantify.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblJudul = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnKeRegister = new Button();
            lblError = new Label();
            panelkiri = new Panel();
            label1 = new Label();
            pctLogo = new PictureBox();
            lblTanyaAkun = new Label();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(75, 96, 67);
            lblJudul.Location = new Point(424, 141);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(205, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Masuk ke akun Plantify-mu!";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(424, 173);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(424, 205);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(314, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(424, 246);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(424, 281);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(314, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(75, 96, 67);
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(424, 351);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(314, 37);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnKeRegister
            // 
            btnKeRegister.BackColor = Color.Transparent;
            btnKeRegister.FlatAppearance.BorderColor = Color.FromArgb(221, 234, 209);
            btnKeRegister.FlatAppearance.BorderSize = 0;
            btnKeRegister.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeRegister.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeRegister.FlatStyle = FlatStyle.Flat;
            btnKeRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeRegister.ForeColor = Color.FromArgb(75, 96, 67);
            btnKeRegister.Location = new Point(625, 399);
            btnKeRegister.Name = "btnKeRegister";
            btnKeRegister.Size = new Size(125, 29);
            btnKeRegister.TabIndex = 6;
            btnKeRegister.Text = "Daftar di sini";
            btnKeRegister.UseVisualStyleBackColor = false;
            btnKeRegister.Click += btnKeRegister_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(517, 423);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 7;
            // 
            // panelkiri
            // 
            panelkiri.BackColor = Color.FromArgb(199, 221, 181);
            panelkiri.BackgroundImage = (Image)resources.GetObject("panelkiri.BackgroundImage");
            panelkiri.BackgroundImageLayout = ImageLayout.Stretch;
            panelkiri.Dock = DockStyle.Left;
            panelkiri.Location = new Point(0, 0);
            panelkiri.Name = "panelkiri";
            panelkiri.Size = new Size(330, 450);
            panelkiri.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(75, 96, 67);
            label1.Location = new Point(405, 75);
            label1.Name = "label1";
            label1.Size = new Size(364, 30);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang di Plantify!";
            // 
            // pctLogo
            // 
            pctLogo.BackColor = Color.Transparent;
            pctLogo.BackgroundImage = Plantify.Properties.Resources.a7e06774_5e62_4ee1_a088_40968eabf182;
            pctLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pctLogo.Location = new Point(649, 7);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(123, 60);
            pctLogo.TabIndex = 9;
            pctLogo.TabStop = false;
            // 
            // lblTanyaAkun
            // 
            lblTanyaAkun.AutoSize = true;
            lblTanyaAkun.Location = new Point(502, 403);
            lblTanyaAkun.Name = "lblTanyaAkun";
            lblTanyaAkun.Size = new Size(137, 20);
            lblTanyaAkun.TabIndex = 10;
            lblTanyaAkun.Text = "Belum punya akun?";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(800, 450);
            Controls.Add(lblTanyaAkun);
            Controls.Add(label1);
            Controls.Add(pctLogo);
            Controls.Add(panelkiri);
            Controls.Add(lblError);
            Controls.Add(btnKeRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblJudul);
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnKeRegister;
        private Label lblError;
        private Panel panelkiri;
        private Label label1;
        private PictureBox pctLogo;
        private Label lblTanyaAkun;
    }
}