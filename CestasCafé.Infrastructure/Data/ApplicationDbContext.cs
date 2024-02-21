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

            modelBuilder.Entity<Cestas>().HasData(
                new Cesta
            {
                Id = 1,
                Name = "Royal Villa",
                Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                ImageUrl = "https://placehold.co/600x400",
                Occupancy = 4,
                Price = 200,
               
            },

    new Cesta
    {
        Id = 2,
        Name = "Premium Pool Villa",
        Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
        ImageUrl = "https://placehold.co/600x401",
        Occupancy = 4,
        Price = 300,
       
    },
    new Cesta
    {
        Id = 3,
        Name = "Luxury Pool Villa",
        Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
        ImageUrl = "https://placehold.co/600x402",
        Occupancy = 4,
        Price = 400,
        
    }
);

           
                    

           
     
        }
    }
}