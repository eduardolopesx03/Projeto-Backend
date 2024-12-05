namespace BurguerManiaAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; } = null!; // Garantir inicialização pelo EF
        public decimal Value { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>(); // Inicializar coleção
    }
}
