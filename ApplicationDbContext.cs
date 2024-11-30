using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<CartProduct>? CartProduct { get; set; }
    public DbSet<Order>? Order { get; set; }
    public DbSet<OrderProduct>? OrderProduct { get; set; }
    public DbSet<Product>? Product { get; set; }
    public DbSet<User>? User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "Alitzel",
                LastName = "C",
                Email = "alitzel@gmail.com",
                Password = "Cisco123",
                Admin = true,
            }
        );
    }
}