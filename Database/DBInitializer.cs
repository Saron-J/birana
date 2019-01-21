using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;
namespace Database
{
    public class DBInitialize: DropCreateDatabaseIfModelChanges<BiranaDatabase>
    {
        protected override void Seed(BiranaDatabase context)
        {
            // add stuffs here
            base.Seed(context);
        }
    }
}
