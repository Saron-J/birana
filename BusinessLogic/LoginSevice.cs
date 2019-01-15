using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Database;

namespace BusinessLogic
{
   public class LoginService:ILoginService
    {
        BiranaDatabase db = new BiranaDatabase();
        
        public LoginService(BiranaDatabase db)
        {
            this.db = db;
        }
        public bool SignIn(User u)
        {
            var user = db.Customer.
                 Where(u1 => u1.email == u1.email &&
                             u1.PasswordHashed == u.Password).
                             FirstOrDefault();
            if (user == null)
                return false;
            else
                return true;
        }
    }
}
