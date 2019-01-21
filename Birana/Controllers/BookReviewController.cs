using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database;
using Domain;
using ViewModel;
using BusinessLogic;
namespace Birana.Controllers
{
    public class BookReviewController : Controller
    {
        IBookReviewService bR;
        public BookReviewController()
        {
            BiranaDatabase bdb = new BiranaDatabase();
            bR = new BookReviewService(bdb);
        }
        // GET: BookReview
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult BookReview()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BookReview(BookReviewModel brmodel)
        {
            int isbn = brmodel.BookISBN;
            var v = bR.DisplayReview(isbn);
            return View(v);
        }
    }
}