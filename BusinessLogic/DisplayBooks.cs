using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Database;
using ViewModel;

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
       public List<BookViewModel> ListSearchedBooks()
        {
            // needs somecode here
            List<BookViewModel> searchedBooks = new List<BookViewModel>();
            searchedBooks = bDb.Book.Where(x=>true).Select(item => new BookViewModel { BookTitle = item.Title, frontPageImg = item.BookFrontPage.ToString(), Price = item.price.ToString() }).ToList();

            return searchedBooks;

        }
        public Book BookDescription(int ISBN)
        {
           
            var bookdis = bDb.Book.Where(x=>x.ISBN==ISBN).ToList().FirstOrDefault();
            return bookdis;
        }

    }
}
