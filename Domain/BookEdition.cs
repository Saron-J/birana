using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BookEdition
    {
        public int Book_Edition { get; set; }
        [ForeignKey("ISBN")]
        public virtual Book BookISBN { get; set; }
        
    }
}
