using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ViewModel
{
    public class UserViewModel_Signup
    {
        [Required(ErrorMessage ="First name is required")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Middle initial is required")]
        public String MiddleInitial { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public String email { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "password is required")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        public String PhoneNum { get; set; }
        [Required(ErrorMessage = "City is required")]
        public String City { get; set; }
        [Required(ErrorMessage = "Subcity is required")]
        public String SubCity { get; set; }
        [Required(ErrorMessage = "House number is required")]
        public int houseNo { get; set; }
    }
}
