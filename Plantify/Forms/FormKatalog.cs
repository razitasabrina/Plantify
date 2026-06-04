using System;
using System.Data;
using System.Windows.Forms;
using Plantify.Controllers;
using Plantify.Models;

namespace Plantify.Forms
{
    public partial class FormKatalog : Form
    {
        private Customer _customerLogin;
        private BibitController _bibitController = new BibitController();

        public FormKatalog(Customer customer)
        {
            InitializeComponent();
            _customerLogin = customer;
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
            dgvKatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKatalog.MultiSelect = false;
            dgvKatalog.ReadOnly = true;
            dgvKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MuatKategori()
        {
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Semua Kategori");

            try
            {
                // Panggil controller
                List<string> kategoriList = _bibitController.GetKategori();
                foreach (var k in kategoriList)
                    cmbKategori.Items.Add(k);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat kategori: " + ex.Message);
            }

            cmbKategori.SelectedIndex = 0;
        }

        private void MuatKatalog(string keyword = "", string kategori = "")
        {
            try
            {
                // Panggil controller
                DataTable dt = _bibitController.GetKatalog(keyword, kategori);
                dgvKatalog.DataSource = dt;

                if (dgvKatalog.Columns.Contains("id"))
                    dgvKatalog.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat katalog: " + ex.Message);
            }
        }

        private void dgvKatalog_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKatalog.SelectedRows.Count == 0) return;

            int idBibit = Convert.ToInt32(dgvKatalog.SelectedRows[0].Cells["id"].Value);
            TampilkanDetail(idBibit);
        }

        private void TampilkanDetail(int idBibit)
        {
            try
            {
                // Panggil controller
                Bibit b = _bibitController.GetDetailBibit(idBibit);

                if (b != null)
                {
                    rtbDetail.Text =
                        $"Nama    : {b.NamaBibit}\n" +
                        $"Kategori: {b.Kategori}\n" +
                        $"Harga   : {b.FormatHarga()} / {b.Satuan}\n" +
                        $"Stok    : {b.Stok} {b.Satuan}\n\n" +
                        $"Deskripsi:\n{b.Deskripsi}";

                    btnBeli.Enabled = b.TersediaStok();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat detail: " + ex.Message);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            string kategori = cmbKategori.SelectedItem?.ToString() ?? "";
            MuatKatalog(keyword, kategori);
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            string kategori = cmbKategori.SelectedItem?.ToString() ?? "";
            MuatKatalog(keyword, kategori);
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (dgvKatalog.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih bibit terlebih dahulu!");
                return;
            }

            string namaBibit = dgvKatalog.SelectedRows[0].Cells["Nama Bibit"].Value.ToString();
            MessageBox.Show($"Bibit \"{namaBibit}\" siap dibeli.\n(Sambungkan ke FormTransaksi kelompok 4)",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}