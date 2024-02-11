using CestasCafé.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CestasCafé.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cestas> Cesta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cestas>().HasData();
        }
    }
}