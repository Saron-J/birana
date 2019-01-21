using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ViewModel;

namespace BusinessLogic
{
    public interface IBookReviewService
    {
       BookReview addReview(BookReviewModel breview);
       List<BookReview> DisplayReview(int isbn);
    }
}
