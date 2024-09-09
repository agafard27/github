using NGCPS.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace NGCPS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<warehouse> warehouse { get; set; }
        public DbSet<customer> customer { get; set; }

        public DbSet<warehousesq> warehousesq { get; set; }

        public DbSet<customersq> customersq { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CustomerView varlığı için HasNoKey() kullanılıyor
            modelBuilder.Entity<customersq>()
                .HasNoKey();
          //  modelBuilder.Entity<warehousesq>().HasNoKey();
        }
    }


}
