using Npgsql;
using plantify.Database;
using plantify.Models;

namespace plantify.Controllers
{
    public class AuthController
    {
        // Logika login — dicek ke database
        public Customer Login(string username, string password)
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
    }
}