namespace BurguerManiaAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicialização padrão
        public string Description { get; set; } = string.Empty; // Inicialização padrão
        public string PathImage { get; set; } = string.Empty; // Inicialização padrão
    }
}
