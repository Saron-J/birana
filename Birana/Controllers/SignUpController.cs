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
    public class SignUpController : Controller
    {
        BiranaDatabase db;
        ISignUpService signUp;
        public SignUpController()
        {
            db = new BiranaDatabase();
            signUp = new SignUpService(db);
        }
        // GET: SignUp
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserViewModel_Signup u)
        {
            if (ModelState.IsValid)
            {
                User usr = signUp.SignUp(u);
                return Redirect(Url.Action("index", "home"));
            }
            else
            {
                ModelState.AddModelError("", "Already registered user or invalid data entry. Try again.");
                return View("");
            }

        }
    }
}