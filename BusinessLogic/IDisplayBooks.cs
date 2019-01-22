using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Domain;
using ViewModel;

namespace BusinessLogic
{
    public interface IDisplayBooks
    {
        List<BookViewModel> ListBooks();
        List<BookViewModel> ListSearchedBooks(String str);
        Book BookDescription(int ISBN);
    }
}
