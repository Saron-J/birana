using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using ViewModel;
using Database;

namespace Birana.Controllers
{
    public class BookDisplayController : Controller
    {
        BiranaDatabase birDb = new BiranaDatabase();
        IDisplayBooks disp;
        public BookDisplayController()
        {
            disp = new DisplayBooks(birDb);
        }
        // GET: BookDisplay
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayBooks()
        {
            return View(disp.ListBooks());
        }
        public ActionResult DiplayDescription(BookViewModel bv)
        {
            int isbn = bv.ISBN;
            return View(disp.BookDescription(isbn));
        }
    }
}