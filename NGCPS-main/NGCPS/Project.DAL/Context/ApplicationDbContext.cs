using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using Project.ENTITIES.Models.quality;
using Project.ENTITIES.Models.qualityEntiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<warehouse> warehouse { get; set; }
        public DbSet<customer> customer { get; set; }
        public DbSet<quality>quality { get; set; }
        public DbSet<qualitysq> qualitysq { get; set; }
        public DbSet<warehousesq> warehousesq { get; set; }

        public DbSet<customersq> customersq { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CustomerView varlığı için HasNoKey() kullanılıyor
            modelBuilder.Entity<customersq>()
                .HasNoKey();
            modelBuilder.Entity<warehousesq>().HasNoKey();
            modelBuilder.Entity<quality>().HasNoKey();
            modelBuilder.Entity<qualitysq>().HasNoKey();
        }
    }
}
