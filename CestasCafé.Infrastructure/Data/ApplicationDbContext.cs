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
                new Cestas
            {
                Id = 1,
                Nome = "Royal Villa",
                Descrição = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                ImageUrl = "https://placehold.co/600x400",
                Ocasião = 4,
                Preço = 200,
               
            },

    new Cestas
    {
        Id = 2,
        Nome = "Premium Pool Villa",
        Descrição = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
        ImageUrl = "https://placehold.co/600x401",
        Ocasião = 4,
        Preço = 300,
       
    },
    new Cestas
    {
        Id = 3,
        Nome = "Luxury Pool Villa",
        Descrição = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
        ImageUrl = "https://placehold.co/600x402",
        Ocasião = 4,
        Preço = 400,
        
    }
);

           
                    

           
     
        }
    }
}