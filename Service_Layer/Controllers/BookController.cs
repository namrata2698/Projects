using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service_Layer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : Controller
    {
        BookRepository repo;
        public BookController()
        {
            repo = new BookRepository();
        }

        [HttpGet]
        public JsonResult GetAllBooks()
        {
            List<DAL_Layer.Models.Books> booklist = null;
            try
            {
                booklist = repo.GetAllBooks();
            }
            catch (Exception)
            {
                booklist = null;
            }
            return Json(booklist);
        }
        [HttpGet]
        public JsonResult GetBookByTitle(string title)
        {
            DAL_Layer.Models.Books book = null;
            try
            {
                book = repo.GetBookByTitle(title);
            }
            catch (Exception)
            {
                book = null;
            }
            return Json(book);
        }
        [HttpGet]
        public JsonResult GetBookByAuthor(string author)
        {
            List<DAL_Layer.Models.Books> booklist = null;
            try
            {
                booklist = repo.GetBookByAuthor(author);
            }
            catch (Exception)
            {
                booklist = null;
            }
            return Json(booklist);
        }
        [HttpGet]
        public JsonResult GetBookByIsbn(string isbn)
        {
            DAL_Layer.Models.Books book = null;
            try
            {
                book = repo.GetBookByIsbn(isbn);
            }
            catch (Exception)
            {
                book = null;
            }
            return Json(book);
        }

        [HttpPost]
        public bool AddBook(string Isbn, string Title, string Author, string Publisher, string Year)
        {
            bool status = false;
            try
            {
                status = repo.AddBook(Isbn, Title, Author, Publisher, Year);
                
            }
            catch (Exception )
            {
                status = false;
            }
            return status;
        }

        [HttpPut]
        public bool UpdateBook(string Isbn, string Title, string Author, string Publisher, string Year)
        {
            bool status = false;
            try
            {
                status = repo.UpdateBook(Isbn, Title, Author, Publisher, Year);

            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        [HttpDelete]
        public bool DeleteBook(string Isbn)
        {
            bool status = false;
            try
            {
                status = repo.DeleteBook(Isbn);

            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

    }
}