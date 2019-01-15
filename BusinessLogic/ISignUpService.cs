using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ViewModel;
namespace BusinessLogic
{
    public interface ISignUpService
    {
       User SignUp(UserViewModel_Signup u);
    }
}
