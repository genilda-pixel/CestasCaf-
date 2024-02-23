using CestasCafé.Domain.Entidades;
using System.Collections;

namespace CestasCafé.Infrastructure.Data
{
    internal class Cesta : IEnumerable<Cestas>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public string ?ImageUrl { get; set; }
        public int Occupancy { get; set; }
        public int Price { get; set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }

        public IEnumerator<Cestas> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}