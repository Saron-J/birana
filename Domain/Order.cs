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
       public String OrderedBookISBN { get; set; }
       public String CustEmail { get; set; }
       public DateTime dateOfOrder{get;set;}
       [ForeignKey("OrderedBookISBN")]
       public virtual Book ISBN { get; set; }
       [ForeignKey("CustEmail")]
       public virtual Customer Email { get; set; }
    }
}
