﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.DAO
{
    public class DataProvider
    {

        //private string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DBQuanLyPhongKham.mdf;Integrated Security=True";
        private string db = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {   
                if (instance == null)
                    instance = new DataProvider();
                return instance;

            }
            private set => instance = value;
        }

        private DataProvider() { }
        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(db))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para[0] == '@')
                        {
                            command.Parameters.AddWithValue(para, paramater[i++]);
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] paramater = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(db))
            {
                
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para[0] == '@')
                        {
                            command.Parameters.AddWithValue(para, paramater[i++]);
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(db))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para[0] == '@')
                        {
                            command.Parameters.AddWithValue(para, paramater[i++]);
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }
    }
}