using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Database;
using ViewModel;
using System.Data.Linq.SqlClient;

namespace BusinessLogic
{
    public class DisplayBooks:IDisplayBooks
    {
        BiranaDatabase bDb;
        public DisplayBooks(BiranaDatabase bDb)
        {
            bDb = this.bDb;
        }
        public List<BookViewModel> ListBooks()
        {
            List<BookViewModel> books = new List<BookViewModel>();
            books = bDb.Book.Where(x => true).Select(item=> new BookViewModel { BookTitle=item.Title,isRecent=item.isRecent,frontPageImg=item.BookFrontPage,Price=item.price.ToString()}).ToList();
            return books; ;
        }
       public List<BookViewModel> ListSearchedBooks(String str)
        {
            // needs somecode here
            List<BookViewModel> searchedBooks = new List<BookViewModel>();
            //searchedBooks = bDb.Book.Where((x=>x.Title)SqlMethods.Like(x,"%str%")).OrderBy).Select(item => new BookViewModel { BookTitle = item.Title, frontPageImg = item.BookFrontPage.ToString(), Price = item.price.ToString() }).ToList();
            var x = from z in bDb.Book
                    where SqlMethods.Like(z.Title, "%str%")
                    select z;
            searchedBooks = x.Select(item => new BookViewModel { BookTitle = item.Title, frontPageImg = item.BookFrontPage.ToString(), Price = item.price.ToString() }).ToList();// }) 
            return searchedBooks;

        }
        public Book BookDescription(int ISBN)
        {
           
            var bookdis = bDb.Book.Where(x=>x.ISBN==ISBN).ToList().FirstOrDefault();
            return bookdis;
        }

    }
}
