using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database;
using Domain;
using BusinessLogic;
using ViewModel;

namespace Birana.Controllers
{
    public class BookUploadController: Controller
    {
        [Authorize]
        // GET: BookUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult BookUpload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BookUpload(BookUploadVM bu)
        {
            return View();
        }


    }
}