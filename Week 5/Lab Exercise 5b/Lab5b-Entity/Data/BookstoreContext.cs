using System;
using System.Collections.Generic;
using System.Text;
using Lab5b_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5b_Entity.Data
{
    class BookstoreContext: DbContext
    {
        // Inherits from DbContext class (represents session with the database)

        // Properties (represent the tables in the database)
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        // Override this to use the SQL Server extension method (hard code the db location for now)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookstoreContext");
        }
    }
}
