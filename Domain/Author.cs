using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    public class Author
    {
        [Key]
        public String AuthorID { get; set; }
        public String AuthorFirstName { get; set; }
        public String AuthorMiddleInitial { get; set; }
        public String AuthorLastName { get; set; }
        public String AuthorPageLink { get; set; }
    }
}
