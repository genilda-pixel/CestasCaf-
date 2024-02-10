namespace CestasCafé.Domain.Entidades
{
    public class Cestas
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string? Descrição { get; set; }
        public double Preço  { get; set; }  
        public int Datas { get; set;}
        public int Ocasião { get; set;}
        public string? ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
            
    }
}
