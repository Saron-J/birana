using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Database;
using Domain;


namespace Database
{
    public class BiranaDatabase:DbContext
    {
        public BiranaDatabase(): base("name=BiranaDB") {
            System.Data.Entity.Database.SetInitializer<BiranaDatabase>(new DBInitialize());
        }

        public DbSet<Admins> Admins { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookEdition> BookEdition { get; set; }
        public DbSet<BookReview> BookReview { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        

    }
}
