using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BookReview
    {
        [Key]
       public String BookReviewID { get; set; }
       public int Rating { get; set; }
       public String ReviewContent { get; set; }
       public String BEmail { get; set; }
       [ForeignKey("BEmail")]
       public virtual Customer Customer { get; set; }
        public int BookISBN { get; set; }
        [ForeignKey("BookISBN")]
        public virtual Book book { get; set; }
    }
}
