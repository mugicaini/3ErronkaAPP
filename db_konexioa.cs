using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace KIROLDEAGIA
{
    internal class db_konexioa
    {
        // konexioa
        string connectionString = "server=127.0.0.1;port=3310;database=erronka3;uid=root;password=;SslMode=Preferred;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public MySqlConnection OpenConnection()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            return con;
        }
    }
}