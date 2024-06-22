using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Domain.Entities;

namespace ProductManagementSystem.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
