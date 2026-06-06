using System;
using Npgsql;

namespace plantify.Database
{
    public class DBConnection
    {
        private static string connectionString =
    "Host=localhost;Port=5432;Database=plantify;Username=postgres;Password=;";

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal koneksi ke database: " + ex.Message);
            }
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}