using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryApplication.Repository
{
    public class BookRepository
    {
        private DBConnection db = new DBConnection();
        private SqlCommand cmd;
        private SqlDataReader reader;

        public void addABook(BookModel newBook)
        {
            SqlConnection conn = db.initializare();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(Query.createABook, conn);
                cmd.Parameters.Add(new SqlParameter("@bookName", newBook.bookName));
                cmd.Parameters.Add(new SqlParameter("@bookType", newBook.bookType));
                cmd.Parameters.Add(new SqlParameter("@bookAuthor", newBook.bookAuthor));
                cmd.ExecuteNonQuery();
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
        public void deteleABook(int bookId)
        {
            SqlConnection conn = db.initializare();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(Query.deleteABook, conn);
                cmd.Parameters.Add(new SqlParameter("@bookId", bookId));
                cmd.ExecuteNonQuery();
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
        public void rentABook(int bookId,int userId)
        {
            SqlConnection conn = db.initializare();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(Query.rentABook, conn);
                cmd.Parameters.Add(new SqlParameter("@userId", userId));
                cmd.Parameters.Add(new SqlParameter("@bookId", bookId));
                cmd.ExecuteNonQuery();
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
    }
}