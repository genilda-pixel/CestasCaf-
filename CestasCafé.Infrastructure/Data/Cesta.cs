using CestasCafé.Domain.Entidades;

namespace CestasCafé.Infrastructure.Data
{
    internal class Cesta : IEnumerable<Cestas>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Occupancy { get; set; }
        public int Price { get; set; }
    }
}