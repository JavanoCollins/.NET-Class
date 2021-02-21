using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab6a.Models;

namespace Lab6a.Data
{
    public class Lab6aContext : DbContext
    {
        public Lab6aContext (DbContextOptions<Lab6aContext> options)
            : base(options)
        {
        }

        public DbSet<Lab6a.Models.Product> Product { get; set; }
    }
}
