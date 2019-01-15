using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    public class Payment
    {
        [Key]
        public String AccountNumber { get; set; }
        public int Amount { get; set; }
        public double Discount { get; set; }
        [ForeignKey("Email")]
        public virtual Customer pEmail { get; set; }
    }
}
