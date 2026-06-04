using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using Plantify.Database;
using Plantify.Models;

namespace Plantify.Forms
{
    public partial class FormKatalog : Form
    {
        private Customer _customerLogin;

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
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "SELECT DISTINCT kategori FROM bibit ORDER BY kategori";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            cmbKategori.Items.Add(reader["kategori"].ToString());
                    }
                }
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
                using (var conn = DBConnection.GetConnection())
                {
                    string query = @"SELECT id,
                                     nama_bibit AS ""Nama Bibit"",
                                     kategori AS ""Kategori"",
                                     TO_CHAR(harga, 'FM999,999,999') AS ""Harga (Rp)"",
                                     stok AS ""Stok"",
                                     satuan AS ""Satuan""
                                     FROM bibit
                                     WHERE stok > 0";

                    if (!string.IsNullOrEmpty(keyword))
                        query += " AND LOWER(nama_bibit) LIKE LOWER(@keyword)";

                    if (!string.IsNullOrEmpty(kategori) && kategori != "Semua Kategori")
                        query += " AND kategori = @kategori";

                    query += " ORDER BY nama_bibit";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(keyword))
                            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                        if (!string.IsNullOrEmpty(kategori) && kategori != "Semua Kategori")
                            cmd.Parameters.AddWithValue("@kategori", kategori);

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvKatalog.DataSource = dt;
                            if (dgvKatalog.Columns.Contains("id"))
                                dgvKatalog.Columns["id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat katalog: " + ex.Message);
            }
        }

        private void dgvKatalog_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKatalog.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvKatalog.SelectedRows[0];
            int idBibit = Convert.ToInt32(row.Cells["id"].Value);
            TampilkanDetail(idBibit);
        }

        private void TampilkanDetail(int idBibit)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = @"SELECT nama_bibit, kategori, deskripsi, 
                                     harga, stok, satuan 
                                     FROM bibit WHERE id = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idBibit);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Bibit b = new Bibit(
                                    idBibit,
                                    reader["nama_bibit"].ToString(),
                                    reader["kategori"].ToString(),
                                    reader["deskripsi"].ToString(),
                                    Convert.ToDecimal(reader["harga"]),
                                    Convert.ToInt32(reader["stok"]),
                                    reader["satuan"].ToString()
                                );

                                rtbDetail.Text =
                                    $"Nama    : {b.NamaBibit}\n" +
                                    $"Kategori: {b.Kategori}\n" +
                                    $"Harga   : {b.FormatHarga()} / {b.Satuan}\n" +
                                    $"Stok    : {b.Stok} {b.Satuan}\n\n" +
                                    $"Deskripsi:\n{b.Deskripsi}";

                                btnBeli.Enabled = b.TersediaStok();
                            }
                        }
                    }
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

            int idBibit = Convert.ToInt32(dgvKatalog.SelectedRows[0].Cells["id"].Value);
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