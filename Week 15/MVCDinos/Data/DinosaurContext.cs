using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCDinos.Models;

namespace MVCDinos.Data
{
    public class DinosaurContext : DbContext
    {

        public DbSet<Dinosaur> Dinosaurs { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Period> Periods { get; set; }

        public DinosaurContext(DbContextOptions<DinosaurContext> options) : base(options)
        {

        }
    }
}
