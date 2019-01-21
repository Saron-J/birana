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
        public String DEmail { get; set; }
        public String wName { get; set; }
        [ForeignKey("DEmail")]
        public virtual Customer Email { get; set; }
        [ForeignKey("wName")]
        public virtual Warehouse warehouseName { get; set; }
    }

}
