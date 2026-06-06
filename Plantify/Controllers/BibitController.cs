using System.Data;
using Npgsql;
using plantify.Database;
using plantify.Models;

namespace plantify.Controllers
{
    public class BibitController
    {
        // Ambil semua kategori dari database
        public List<string> GetKategori()
        {
            List<string> kategoriList = new List<string>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT kategori FROM bibit ORDER BY kategori";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        kategoriList.Add(reader["kategori"].ToString());
                }
            }

            return kategoriList;
        }

        // Ambil daftar bibit dengan filter keyword dan kategori
        public DataTable GetKatalog(string keyword = "", string kategori = "")
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
                        return dt;
                    }
                }
            }
        }

        // Ambil detail satu bibit berdasarkan id
        public Bibit GetDetailBibit(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT nama_bibit, kategori, deskripsi, 
                                 harga, stok, satuan 
                                 FROM bibit WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Bibit(
                                id,
                                reader["nama_bibit"].ToString(),
                                reader["kategori"].ToString(),
                                reader["deskripsi"].ToString(),
                                Convert.ToDecimal(reader["harga"]),
                                Convert.ToInt32(reader["stok"]),
                                reader["satuan"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }
    }
}