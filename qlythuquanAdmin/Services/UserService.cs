﻿using MySql.Data.MySqlClient;
using qlythuquanAdmin.database;
using qlythuquanAdmin.Model;
using System.Collections.Generic;
using System.Data;
using qlythuquanAdmin.database;

namespace qlythuquanAdmin.Services
{
    public class UserService
    {
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
                            Birthday = reader.IsDBNull("birthday") ? "" : reader.GetDateTime("birthday").ToString("dd/MM/yyyy"),
                            Phone = reader.IsDBNull("phone") ? "" : reader.GetString("phone")
                        });
                    }
                }
            }

            return list;
        }
    }
}
