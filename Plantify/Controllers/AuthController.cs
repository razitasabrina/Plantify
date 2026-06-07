using System;
using Npgsql;
using plantify.Database;
using plantify.Models;

namespace plantify.Controllers
{
    public class AuthController
    {
        public Customer Login(string username, string password)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT id_user, nama_user, email, no_telepon, alamat
                                 FROM users 
                                 WHERE email = @username 
                                 AND passwords = @password 
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
                                Convert.ToInt32(reader["id_user"]),
                                reader["nama_user"].ToString(),
                                reader["email"].ToString(),
                                reader["email"].ToString(),
                                reader["alamat"].ToString(),
                                reader["no_telepon"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }
    }
}