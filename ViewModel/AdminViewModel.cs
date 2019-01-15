using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
   public class AdminViewModel
    {
        [Required(ErrorMessage ="First Name is required.")]
        public String AdminFirstName { get; set; }
        public String AdminMiddleInitial { get; set; }
        [Required(ErrorMessage ="Last Name is required.")]
        public String AdminLastName { get; set; }
        [Required(ErrorMessage ="Email is required")]
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
