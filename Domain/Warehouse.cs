using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Domain
{
    public class Warehouse
    {
        [Key]
        public String warehouseName { get; set; }
        public String City { get; set; }
        public String SubCity { get; set; }
        public int HouseNo { get; set; }
        public int NumberofBooks { get; set; }
    }
}
