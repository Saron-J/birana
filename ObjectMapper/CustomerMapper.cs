using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using Domain;

namespace ObjectMapper
{
    public static class CustomerMapper
    {
        public static Customer ToDomainModel(this UserViewModel_Signup cust)
        {
            //This function adds A customer TO Customer table in the Database
            Customer Cst = new Customer();
            Cst.LastName = cust.LastName;
            Cst.MiddleInitial= cust.MiddleInitial;
            Cst.FirstName= cust.FirstName;
            Cst.houseNo = cust.houseNo;
            Cst.SubCity = cust.SubCity;
            Cst.City = cust.City;
            Cst.DateOfBirth = cust.DOB;
            Cst.email = cust.email;
            Cst.PasswordHashed = cust.Password;// needs some improvements to include password hashing
            return Cst;
        }
    }
}
