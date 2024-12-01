using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<CartProduct>? CartProducts { get; set; }
    public DbSet<Order>? Orders { get; set; }
    public DbSet<OrderProduct>? OrderProducts { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<User>? Users { get; set; }

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
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Diviltac",
                Description = "Jeje",
                Image = "https://http2.mlstatic.com/D_NQ_NP_636771-MLM78569019015_082024-O.webp",
                Price = 49,
                Amount = 10,
            }
        );
    }
}