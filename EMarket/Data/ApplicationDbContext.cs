using EMarket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMarket.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Goods> Goods => Set<Goods>();
        public DbSet<Sales> Sales => Set<Sales>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder
               .Entity<Category>()
               .Property(e => e.Created)
               .HasDefaultValueSql("now()");

            modelBuilder
               .Entity<Goods>()
               .Property(e => e.Created)
               .HasDefaultValueSql("now()");

            modelBuilder
               .Entity<Sales>()
               .Property(e => e.Created)
               .HasDefaultValueSql("now()");
        }
    }
}
