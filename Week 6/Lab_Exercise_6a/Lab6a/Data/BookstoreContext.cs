using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab6a.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6a.Data
{
    public class BookstoreContext : DbContext
    {
        // Properties (database tables)
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        // Constructor
        public BookstoreContext(DbContextOptions options) : base(options)
        {
        }
    }
}
