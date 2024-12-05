namespace BurguerManiaAPI.Models
{
    public class UserOrder
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!; // Garantir inicialização pelo EF

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!; // Garantir inicialização pelo EF
    }
}
