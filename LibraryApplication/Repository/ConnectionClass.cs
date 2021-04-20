using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static LibraryApplication.Models.UserModel;

namespace LibraryApplication.Repository
{
    public class ConnectionClass
    {
        private DBConnection db = new DBConnection();
        private SqlCommand cmd;
        private SqlDataReader reader;
        public void UserLogin(LoginCredentials login)
        {
            SqlConnection conn = db.initializare();
            try
            {
                cmd = new SqlCommand(Query.loginQuery, conn);
                cmd.Parameters.Add(new SqlParameter("username", login.username));
                cmd.Parameters.Add(new SqlParameter("password", login.password));
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        fetchUserInformation(Int32.Parse(reader["user_id"].ToString())) ;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                conn.Dispose();
                conn.Close();
            }
        }
        public UserModel fetchUserInformation(int userId)
        {
            SqlConnection conn = db.initializare();
            UserModel user = null;
            try
            {
                cmd = new SqlCommand(Query.fetchDataAfterLogin, conn);
                cmd.Parameters.Add(new SqlParameter("userId", userId));
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {


                    while (reader.Read())
                    {
                         userId = Int32.Parse(reader["user_id"].ToString());
                        string username = reader["username"].ToString();
                        string password = reader["password"].ToString();
                        string name = reader["name"].ToString();
                        string email = reader["email"].ToString();
                        user = new UserModel(userId, username, password, email, name);

                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                conn.Dispose();
                conn.Close();
            }
            return user;
          
        }
    }
}