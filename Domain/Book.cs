using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
   public class Book
    {
        [Key]
        public String ISBN { get; set; }
        public String Title { get; set; }
        public String YearOfPublication { get; set; }
        public System.IO.FileInfo BookFrontPage { get; set; }
        public double price { get; set; }
        public String BookDescription { get; set; }
        public String Category { get; set; }

        [ForeignKey("PublisherName")]
        public virtual Publisher BookPublisherName { get; set; }

        [ForeignKey("AuthorName")]
        public virtual Author Author { get; set; }
    }
}
