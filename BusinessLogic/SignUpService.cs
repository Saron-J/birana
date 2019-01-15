using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ViewModel;
using Database;
using ObjectMapper;

namespace BusinessLogic
{
    public class SignUpService: ISignUpService
    {
        BiranaDatabase bDb;
        public SignUpService(BiranaDatabase db)
        {
            bDb = db;
        }

        public User SignUp(UserViewModel_Signup u)
        {
            var us = bDb.Customer.Where(c1 => c1.email == u.email).FirstOrDefault();

            // var user = bDb.Users.Where(u1 => u1.UserName == u.employeeID).FirstOrDefault();

            if (us == null)//&& user == null
            {
                Customer cust = new Customer();
                cust = CustomerMapper.ToDomainModel(u);
                bDb.Customer.Add(cust);

                User usr = new User();
                usr.Email = u.email;
                usr.Password = u.Password;

                bDb.User.Add(usr);
                bDb.SaveChanges();
                return usr;

            }
            else
            {
                return null;
            }
        }

    }
}
