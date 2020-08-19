using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EONRealityFinal.Models;

namespace EONRealityFinal.Data
{
    public class EONRealityFinalContext : DbContext
    {
        public EONRealityFinalContext (DbContextOptions<EONRealityFinalContext> options)
            : base(options)
        {
        }

        public DbSet<EONRealityFinal.Models.User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
