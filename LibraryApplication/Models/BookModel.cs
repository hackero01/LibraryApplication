using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string bookName { get; set; }
        public string bookAuthor { get; set; }
        public string bookType { get; set; }

        public BookModel(int BookId,string bookName,string bookAuthor,string bookType)
        {
            this.BookId = BookId;
            this.bookAuthor = bookAuthor;
            this.bookName = bookName;
            this.bookType = bookType;
        }
        public class BookRent
        {
            public int bookId;
            public int userId;
        }



    }
}