namespace BurguerManiaAPI.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!; // Garantir inicialização pelo EF

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!; // Garantir inicialização pelo EF
    }
}
