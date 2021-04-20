using LibraryApplication.Models;
using LibraryApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static LibraryApplication.Models.BookModel;

namespace LibraryApplication.Controllers
{
    public class BookController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/addABook")]
        [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult AddABook([FromBody]  BookModel newBook )
        {
            BookRepository cc = new BookRepository();
            cc.addABook(newBook);
            return Ok();

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/deleteABook")]
        [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult DeleteABook([FromBody] BookModel bookId)
        {
            BookRepository cc = new BookRepository();
            cc.deteleABook(bookId.BookId);
            return Ok();

        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/rentABook")]
        [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult rentABook([FromBody] BookRent rentedBook)
        {
            BookRepository cc = new BookRepository();
            cc.rentABook(rentedBook.bookId,rentedBook.userId);
            return Ok();

        }
    }
}
