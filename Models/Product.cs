namespace BurguerManiaAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicialização padrão
        public string PathImage { get; set; } = string.Empty; // Inicialização padrão
        public decimal Price { get; set; }
        public string BaseDescription { get; set; } = string.Empty; // Inicialização padrão
        public string FullDescription { get; set; } = string.Empty; // Inicialização padrão

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!; // Garantir inicialização pelo EF
    }
}
