using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace qlythuquanAdmin.DAL
{
    internal class DatabaseHelper
    {
        private static string connectionString = "server=localhost;database=qlythuquan;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi truy vấn: " + ex.Message);
            }
            return dt;
        }

        public static bool ExecuteNonQuery(string query)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi thực thi: " + ex.Message);
                return false;
            }
        }
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
