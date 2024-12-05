using Microsoft.EntityFrameworkCore;
using BurguerManiaAPI.Models;

namespace BurguerManiaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrdersProducts { get; set; }
        public DbSet<UserOrder> UsersOrders { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
