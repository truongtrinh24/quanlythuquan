using MySql.Data.MySqlClient;
using qlythuquanAdmin.database;
using qlythuquanAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlythuquanAdmin.Services
{
    internal class LoginService
    {
        public static Login Login(string email, string password)
        {
            Login? user = null;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT email, password_hash, role_id FROM users WHERE email = @Email AND password_hash = @Password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new Login
                            {
                                Email = reader.GetString("email"),
                                PasswordHash = reader.GetString("password_hash"),
                                RoleId = reader.GetInt32("role_id")
                            };
                        }
                    }
                }
            }

            return user;
        }


    }
}
