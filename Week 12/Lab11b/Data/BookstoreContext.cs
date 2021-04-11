using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab11b.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab11b.Data
{
    public class BookstoreContext : DbContext
    {
        // Properties (database tables)
        public DbSet<Product> Products { get; set; }

        // Constructor
        public BookstoreContext(DbContextOptions options) : base(options)
        {
        }
    }
}
