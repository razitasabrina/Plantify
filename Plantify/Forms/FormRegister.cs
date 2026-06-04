using System;
using System.Windows.Forms;
using Npgsql;
using Plantify.Database;

namespace Plantify.Forms
{
    public partial class FormRegister : Form
    {
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
                if (UsernameExists(username))
                {
                    lblError.Text = "Username sudah digunakan, pilih username lain.";
                    return;
                }

                if (EmailExists(email))
                {
                    lblError.Text = "Email sudah terdaftar.";
                    return;
                }

                RegisterCustomer(nama, email, username, password, alamat, noHp);

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
                lblError.Text = "Password dan konfirmasi password tidak cocok!";
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

        private bool UsernameExists(string username)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM customer WHERE username = @username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        private bool EmailExists(string email)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM customer WHERE email = @email";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        private void RegisterCustomer(string nama, string email, string username,
                                       string password, string alamat, string noHp)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO customer (nama, email, username, password, alamat, no_hp) 
                                 VALUES (@nama, @email, @username, @password, @alamat, @noHp)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@noHp", noHp);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnKeLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}