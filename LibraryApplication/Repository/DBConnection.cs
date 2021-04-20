using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryApplication.Repository
{
    public class DBConnection
    {
        public SqlConnection initializare()
        {
            string connStr = ConfigurationManager.ConnectionStrings["librarysql"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
        }
    }
}