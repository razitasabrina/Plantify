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
            MuatKategori();
            MuatKatalog();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            //dgvKatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvKatalog.MultiSelect = false;
            //dgvKatalog.ReadOnly = true;
            //dgvKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MuatKategori()
        {
            //cmbKategori.Items.Clear();
            //cmbKategori.Items.Add("Semua Kategori");

            //try
            //{
            //    // Panggil controller
            //    List<string> kategoriList = _bibitController.GetKategori();
            //    foreach (var k in kategoriList)
            //        cmbKategori.Items.Add(k);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Gagal memuat kategori: " + ex.Message);
            //}

            //cmbKategori.SelectedIndex = 0;
        }

        private void MuatKatalog(string keyword = "", string kategori = "")
        {
            //try
            //{
            //    // Panggil controller
            //    DataTable dt = _bibitController.GetKatalog(keyword, kategori);
            //    dgvKatalog.DataSource = dt;

            //    if (dgvKatalog.Columns.Contains("id"))
            //        dgvKatalog.Columns["id"].Visible = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Gagal memuat katalog: " + ex.Message);
            //}
        }

        //private void dgvKatalog_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvKatalog.SelectedRows.Count == 0) return;

        //    int idBibit = Convert.ToInt32(dgvKatalog.SelectedRows[0].Cells["id"].Value);
        //    TampilkanDetail(idBibit);
        //}

        private void btnBeli_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Panggil controller
            //    Bibit b = _bibitController.GetDetailBibit(idBibit);

            //    if (b != null)
            //    {
            //        rtbDetail.Text =
            //            $"Nama    : {b.NamaBibit}\n" +
            //            $"Kategori: {b.Kategori}\n" +
            //            $"Harga   : {b.FormatHarga()} / {b.Satuan}\n" +
            //            $"Stok    : {b.Stok} {b.Satuan}\n\n" +
            //            $"Deskripsi:\n{b.Deskripsi}";

            //        btnBeli.Enabled = b.TersediaStok();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Gagal memuat detail: " + ex.Message);
            //}
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            //string keyword = txtCari.Text.Trim();
            //string kategori = cmbKategori.SelectedItem?.ToString() ?? "";
            //MuatKatalog(keyword, kategori);
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string keyword = txtCari.Text.Trim();
        //    string kategori = cmbKategori.SelectedItem?.ToString() ?? "";
        //    MuatKatalog(keyword, kategori);
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