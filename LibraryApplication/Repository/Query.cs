using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Repository
{
    public class Query
    {
        public static string loginQuery = @"
                                            SELECT [user_id]
                                              FROM [dbo].[users] 
										                                              where [username] = @username AND [password] = @password";
        public static string fetchDataAfterLogin = @"SELECT * FROM users WHERE [user_id]=@userId";
        public static string createABook = @"
                                            INSERT INTO [dbo].[books]
                                                       ([book_name]
                                                       ,[book_author]
                                                       ,[book_type])
                                                 VALUES
                                                      (@bookName,@bookAuthor,@bookType)";
        public static string rentABook = @"
                                            INSERT INTO [dbo].[rented_books]
                                                       ([user_id]
                                                       ,[book_id])
                                                 VALUES
                                                      (@userId,@bookId)";
        public static string deleteABook = @"DELETE FROM books WHERE book_id=@bookId";
    }
}