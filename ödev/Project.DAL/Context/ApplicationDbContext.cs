using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
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

        public DbSet<cw_000_quality> cw_000_quality { get; set; }
        public DbSet<cw_000_qualityseq> cw_000_qualityseq { get; set; }
        public DbSet<warehouse> warehouse { get; set; }
        public DbSet<customer> customer { get; set; }
        public DbSet<warehousesq> warehousesq { get; set; }
        public DbSet<customersq> customersq { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // customersq varlığı için HasNoKey() kullanılıyor
            modelBuilder.Entity<customersq>()
                .HasNoKey();

            // warehousesq ve qualitysq varlıkları için HasNoKey() kullanılıyor
            modelBuilder.Entity<warehousesq>().HasNoKey();
            modelBuilder.Entity<cw_000_quality>().HasKey(q => q.qty_referans);
            modelBuilder.Entity<cw_000_qualityseq>().HasKey(q => q.id);
        }
    }
}
