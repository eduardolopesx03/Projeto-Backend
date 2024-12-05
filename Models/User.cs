namespace BurguerManiaAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicialização padrão
        public string Email { get; set; } = string.Empty; // Inicialização padrão
        public string Password { get; set; } = string.Empty; // Inicialização padrão
    }
}
