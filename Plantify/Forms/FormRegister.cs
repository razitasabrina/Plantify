using System;
using System.Windows.Forms;
using plantify.Controllers;

namespace plantify.Forms
{
    public partial class FormRegister : Form
    {
        private CustomerController _customerController = new CustomerController();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string konfirmPassword = txtKonfirmPassword.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            string noHp = txtNoHp.Text.Trim();

            if (!ValidasiInput(nama, email, username, password, konfirmPassword))
                return;

            try
            {
                if (_customerController.UsernameExists(username))
                {
                    lblError.Text = "Username sudah digunakan!";
                    return;
                }

                if (_customerController.EmailExists(email))
                {
                    lblError.Text = "Email sudah terdaftar!";
                    return;
                }

                // Panggil controller untuk simpan ke database
                _customerController.Register(nama, email, username, password, alamat, noHp);

                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidasiInput(string nama, string email, string username,
                                    string password, string konfirmPassword)
        {
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Semua field wajib diisi!";
                return false;
            }

            if (password != konfirmPassword)
            {
                lblError.Text = "Password dan konfirmasi tidak cocok!";
                return false;
            }

            if (password.Length < 6)
            {
                lblError.Text = "Password minimal 6 karakter!";
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                lblError.Text = "Format email tidak valid!";
                return false;
            }

            lblError.Text = "";
            return true;
        }

        private void btnKeLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
    }
}