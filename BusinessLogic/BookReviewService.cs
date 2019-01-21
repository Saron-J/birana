using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ViewModel;
using Database;

namespace BusinessLogic
{
    public class BookReviewService: IBookReviewService
    {
        BiranaDatabase BDB;// = new BiranaDatabase();
        public BookReviewService(BiranaDatabase bdb)
        {
            BDB = bdb;
        }
        public BookReview addReview(BookReviewModel breview)
        { 
            
            BookReview br = new BookReview();
            br.Customer.email = breview.ReviewerEmail;
            br.ReviewContent = breview.ReviewContent;
            br.book.ISBN = breview.BookISBN;
            br.BookReviewID = br.BookReviewID + 1;
            BDB.BookReview.Add(br);
            BDB.SaveChanges();
            return br;
        }
        public List<BookReview> DisplayReview(int isbn)
        {
            List<BookReview> brV = new List<BookReview>();
            brV = BDB.BookReview.Where(x => x.BookISBN == isbn).ToList();
            return brV;
        }
    }
}
