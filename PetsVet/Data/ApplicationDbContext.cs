using Microsoft.EntityFrameworkCore;
using PetsVet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsVet.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
