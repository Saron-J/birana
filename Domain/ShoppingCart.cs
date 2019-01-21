using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    public class ShoppingCart
    {
        [Key]
        public String ShoppingCartId { get; set; }
        public int TotalNumberOfBooks { get; set; }
        public string SEmail { get; set; }


        [ForeignKey("SEmail")]
        public virtual Customer Email { get; set; }
    }
}
