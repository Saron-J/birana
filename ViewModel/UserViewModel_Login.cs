using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ViewModel
{
   public class UserViewModel_Login
    {
        [Required(ErrorMessage ="Username is required")]
        public String Email{get; set;}
        [Required(ErrorMessage ="Password is required")]
        public String Password { get; set; }
    }
}
