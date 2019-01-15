using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
    public class Delivery
    {
        [Key]
        public String trackingNo { get; set; }
        public String Status { get; set; }
        public DateTime deliveryDate { get; set; }
        public double shippingPrice { get; set; }
        [ForeignKey("Email")]
        public virtual Customer dEmail { get; set; }
        [ForeignKey("warehouseName")]
        public virtual Warehouse warehouseName { get; set; }
    }

}
