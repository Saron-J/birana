using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Order
    {
       [Key]
       public DateTime dateOfOrder{get;set;}
        [ForeignKey("ISBNf")]
       public virtual Book OrderedBookISBN { get; set; }
       [ForeignKey("Email")]
       public virtual Customer customerOrderEmail { get; set; }
    }
}
