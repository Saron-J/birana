using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    public class BookReviewModel
    {
        [Required(ErrorMessage = "Username is Required")]
        public String ReviewerEmail { get; set; }
        public int Rating { get; set; }
        public String ReviewContent { get; set; }
        public int BookISBN { get; set; }
    }
}
