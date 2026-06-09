using System.Collections.Generic;
using plantify.Controllers;
using plantify.Models;
using Plantify;
using System;
using System.Data;
using System.Windows.Forms;

namespace plantify.Forms
{
    public partial class FormKatalog : Form
    {
        private Customer _customerLogin;
        private BibitController _bibitController = new BibitController();

        public FormKatalog(Customer customer)
        {
            InitializeComponent();

            _customerLogin = customer;

            UcBibit card1 = new UcBibit();
            UcBibit card2 = new UcBibit();
            UcBibit card3 = new UcBibit();

            card1.Click += Card1_Click;

            flpKatalog.Controls.Add(card1);
            flpKatalog.Controls.Add(card2);
            flpKatalog.Controls.Add(card3);
        }

        private void FormKatalog_Load(object sender, EventArgs e)
        {
            lblSambutan.Text = $"Selamat datang, {_customerLogin.Nama}!";
        }




        private void btnLogout_Click(object sender, EventArgs e)
        {
            var hasil = MessageBox.Show("Yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            lblNamaProduk.Text = "Bibit Tomat";

            lblDeskripsi.Text =
                "Bibit tomat unggul. Cocok ditanam di dataran rendah dan memiliki masa panen sekitar 70 hari.";
        }

        private void btnCari_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNamaProduk_Click(object sender, EventArgs e)
        {

        }

        private void lblKategori_Click(object sender, EventArgs e)
        {

        }
    }
}