using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BookViewModel
    {
        public String BookTitle { get; set; }
        public String frontPageImg { get; set; }
        public String Price { get; set; }
        public bool isRecent { get; set; }
        public int ISBN { get; set; }
    }
}
