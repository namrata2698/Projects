using DAL_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL_Layer
{
    public class BookRepository
    {
        BookdbContext context;
        public BookRepository()
        {
            context = new BookdbContext();
        }


        //-------------------- Read data methods----------------//

        //GetAllBooks
        public List<Books> GetAllBooks()
        {
            List<Books> booklist =null;
            try
            {
                booklist = context.Books.ToList();
                //booklist = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
            catch (Exception)
            {
                booklist = null;
            }
            return booklist;
        }

        //GetBookByTitle
        public Books GetBookByTitle(string title)
        {
            Books book = null;
            try
            {
              book = context.Books.Where(b => b.Title== title).FirstOrDefault();
            }
            catch (Exception)
            {
                book = null;
            }
            return book;
        }

        //GetBookByAuthor
        public List<Books> GetBookByAuthor(string author)
        {
            List<Books> booklist = null;
            try
            {
              booklist = context.Books.Where(b => b.Author == author).ToList();
            }
            catch (Exception)
            {
                booklist = null;
            }
            return booklist;
        }

        //GetBookByIsbn
        public Books GetBookByIsbn(string isbn)
        {
            Books book = null;
            try
            {
                book = context.Books.Where(b => b.Isbn == isbn).FirstOrDefault();
            }
            catch (Exception)
            {
                book = null;
            }
            return book;
        }


        //------------------------- Create data methods----------//

        //AddBook
        public bool AddBook(string Isbn,string Title,string Author,string Publisher,string Year)
        {
            bool status = false;
            Books books = new Books();
            books.Isbn = Isbn;
            books.Publisher = Publisher;
            books.Title = Title;
            books.Author = Author;
            books.Year = Year;
            try
            {
                context.Books.Add(books);
                context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }


        //-----------------------Update data methods---------------//

        //UpdateBook
        public bool UpdateBook(string Isbn, string Title, string Author, string Publisher, string Year)
        {
            bool status = false;
            Books books = context.Books.Where(b => b.Isbn == Isbn).FirstOrDefault();
            if (books != null)
            {
                books.Isbn = Isbn;
                books.Publisher = Publisher;
                books.Title = Title;
                books.Author = Author;
                books.Year = Year;
                context.SaveChanges();
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }


        //------------------ Delete data methods-----------------------//
        //DeleteBook
        public bool DeleteBook(string Isbn)
        {
            Books book = null;
            bool status = false;
            try
            {
                book = context.Books.Find(Isbn);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }





    }
}
