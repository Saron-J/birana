using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Admins
    {
        [Key]
        public String AdminID { get; set; }
        public String Passwordhashed { get; set; }
        public String Email { get; set; }
        public String AdminFirstName { get; set; }
        public String AdminMiddleInitial { get; set; }
        public String AdminLastName { get; set; }
    }
}
