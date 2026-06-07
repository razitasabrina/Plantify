using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using plantify.Database;
using plantify.Models;

namespace plantify.Controllers
{
    public class BibitController
    {
        public List<string> GetKategori()
        {
            List<string> kategoriList = new List<string>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT jenis_bibit FROM bibit ORDER BY jenis_bibit";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        kategoriList.Add(reader["jenis_bibit"].ToString());
                }
            }

            return kategoriList;
        }

        public DataTable GetKatalog(string keyword = "", string kategori = "")
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT id_bibit,
                                 nama_bibit AS ""Nama Bibit"",
                                 jenis_bibit AS ""Kategori"",
                                 TO_CHAR(harga, 'FM999,999,999') AS ""Harga (Rp)"",
                                 stok AS ""Stok""
                                 FROM bibit
                                 WHERE stok > 0";

                if (!string.IsNullOrEmpty(keyword))
                    query += " AND LOWER(nama_bibit) LIKE LOWER(@keyword)";

                if (!string.IsNullOrEmpty(kategori) && kategori != "Semua Kategori")
                    query += " AND jenis_bibit = @kategori";

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

        public Bibit GetDetailBibit(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT nama_bibit, jenis_bibit, deskripsi, 
                                 harga, stok
                                 FROM bibit WHERE id_bibit = @id";

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
                                reader["jenis_bibit"].ToString(),
                                reader["deskripsi"].ToString(),
                                Convert.ToDecimal(reader["harga"]),
                                Convert.ToInt32(reader["stok"]),
                                ""
                            );
                        }
                    }
                }
            }
            return null;
        }
    }
}