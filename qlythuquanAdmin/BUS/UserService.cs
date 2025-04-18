using MySql.Data.MySqlClient;
using qlythuquanAdmin.Model;
using System.Collections.Generic;
using System.Data;
using qlythuquanAdmin.DAL;
using System.Windows.Forms;

namespace qlythuquanAdmin.BUS
{
    public class UserService
    {
        private UserDAL dal = new UserDAL();
        public static List<User> SearchUsers(string keyword)
        {
            List<User> list = new List<User>();
            string query = $@"
                SELECT full_name, address, birthday, phone 
                FROM users 
                WHERE 
                    full_name LIKE @kw OR 
                    address LIKE @kw OR 
                    birthday LIKE @kw OR 
                    phone LIKE @kw";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User
                        {
                            FullName = reader.GetString("full_name"),
                            Address = reader.IsDBNull("address") ? "" : reader.GetString("address"),
                            Birthday = reader.IsDBNull("birthday") ? DateTime.MinValue : reader.GetDateTime("birthday"),

                            Phone = reader.IsDBNull("phone") ? "" : reader.GetString("phone")
                        });
                    }
                }
            }

            return list;
        }
        public bool ThemNguoiDung(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FullName) || string.IsNullOrWhiteSpace(user.Email))
                return false;

            return dal.ThemNguoiDung(user);
        }
    }
}
