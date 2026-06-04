using System;
using System.Windows.Forms;
using Npgsql;
using Plantify.Database;
using Plantify.Models;

namespace Plantify.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Username dan password tidak boleh kosong!";
                return;
            }

            try
            {
                Customer customer = AuthenticateCustomer(username, password);

                if (customer != null)
                {
                    FormKatalog formKatalog = new FormKatalog(customer);
                    formKatalog.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Username atau password salah!";
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Customer AuthenticateCustomer(string username, string password)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT id, nama, email, username, alamat, no_hp 
                                 FROM customer 
                                 WHERE username = @username 
                                 AND password = @password 
                                 LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer(
                                Convert.ToInt32(reader["id"]),
                                reader["nama"].ToString(),
                                reader["email"].ToString(),
                                reader["username"].ToString(),
                                reader["alamat"].ToString(),
                                reader["no_hp"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }

        private void btnKeRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}