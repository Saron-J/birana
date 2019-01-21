using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ViewModel;
using Domain;
using BusinessLogic;
using Database;
namespace Birana.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        ILoginService loginService;
   
        public LoginController( )
        {
            BiranaDatabase db = new BiranaDatabase();
            loginService = new LoginService(db);
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login(String ReturnUrl)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserViewModel_Login user)
        {
            if (ModelState.IsValid)
            {
                User u = new User()
                {
                    Email = user.Email,
                    Password = user.Password
                };
                bool res = loginService.SignIn(u);
                if (res)
                {
                    //Cookie forms authentication
                    FormsAuthentication.SetAuthCookie(u.Email, true);
                    return Redirect(Url.Action("index", "home"));
                }
                else
                {
                    ModelState.AddModelError("", "Wrong Username or Password");
                    return View("");
                }
            }
            else
            {
                return View();
            }
        }

    }
}