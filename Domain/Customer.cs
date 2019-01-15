using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Customer
    {
       public String FirstName { get; set; }
       public String MiddleInitial { get; set; }
       public String LastName { get; set; }
       public String email { get; set; }
       public DateTime DateOfBirth { get; set; }
       public String PasswordHashed { get; set; }
       public String City { get; set; }
       public String SubCity { get; set; }
       public int houseNo { get; set; }
    }
}
