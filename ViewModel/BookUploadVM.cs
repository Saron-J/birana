using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domain;
namespace ViewModel
{
   public class BookUploadVM
    {
        public String BookTitle { get; set; }
        public String ISBN { get; set; }
        public String Description { get; set; }
        public Author Author { get; set; }
        public String BookFrontPageImg { get; set; }
       

    }
}
