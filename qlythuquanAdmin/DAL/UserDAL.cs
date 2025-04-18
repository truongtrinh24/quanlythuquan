using qlythuquanAdmin.Model;
using System;
using MySql.Data.MySqlClient;

namespace qlythuquanAdmin.DAL
{
    public class UserDAL
    {
        public bool ThemNguoiDung(User user)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO users 
                                    (full_name, email, password_hash, phone, birthday, address, role_id, created_at)
                                     VALUES 
                                    (@FullName, @Email, @PasswordHash, @Phone, @Birthday, @Address, @RoleId, @CreatedAt)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                        cmd.Parameters.AddWithValue("@Phone", user.Phone);
                        cmd.Parameters.AddWithValue("@Birthday", user.Birthday);
                        cmd.Parameters.AddWithValue("@Address", user.Address);
                        cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                        cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi thêm người dùng: " + ex.Message);
                return false;
            }
        }
    }
}
