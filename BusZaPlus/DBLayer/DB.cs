﻿using System;
using System.Data.SqlClient;

namespace DBLayer
{
    public static class DB
    {
        private static string _connectionString = @"Data Source=31.147.206.65; Initial Catalog=PI2324_mvukovic22_DB; User=PI2324_mvukovic22_User; Password=o=w:n]zi";
        private static SqlConnection _connection;

        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public static void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }

        public static int ExecuteCommand(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, _connection);
           return command.ExecuteNonQuery();
        }
    }
}