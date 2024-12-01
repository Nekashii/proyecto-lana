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
            },
            new Product
            {
                Id = 2,
                Name = "Botas",
                Description = "Botas de piel",
                Image = "https://prada.mx/cdn/shop/files/82001113BO4NEGTC.jpg?v=1722530022",
                Price = 400,
                Amount = 4,
            },
            new Product 
            { 
                Id = 3,
                Name = "Sandalias",
                Description = "Sandalias de Verano", 
                Image = "https://i.pinimg.com/564x/36/44/cb/3644cbc16a8dd7b678fb8fcf18880893.jpg",
                Price = 350,
                Amount = 0,
            },
            new Product 
            { 
                Id = 4, 
                Name = "zapatillas", 
                Description = "Zapatillas con tacon",
                Image = "https://grecoshoes.mx/cdn/shop/files/FB_IMG_1709660586119.jpg?v=1718479176",
                Price = 500,
                Amount = 2,
            }, 
            new Product 
            { 
                Id = 5, 
                Name = "Maquina de guerra", 
                Description = "Uso del que quieras", 
                Image = "https://armystorepuebla.com.mx/wp-content/uploads/2024/02/1-Pagina-1.png", 
                Price = 500,
                Amount = 5,
            },
            new Product 
            { 
                Id = 6, 
                Name = "Patea Abuelitas", 
                Description = "Perfectas para patear abuelitas ", 
                Image = "https://m.media-amazon.com/images/I/61z7ObMv60L._AC_SY695_.jpg", 
                Price = 99999,
                Amount = 9999,
            },
            new Product 
            { 
                Id = 7, 
                Name = "Rompe Huevos", 
                Description = "Rompe Huevos de Gallina y mas ", 
                Image = "https://img.kwcdn.com/product/Fancyalgo/VirtualModelMatting/71681cd722ec5bb372b77fd5cd8923e7.jpg?imageView2/2/w/800/q/70/format/webp", 
                Price = 999,
                Amount = 0,
            },
            new Product 
            { 
                Id = 8, 
                Name = "Tacones de Puta", 
                Description = "Perfectos para Luz ", 
                Image = "https://m.media-amazon.com/images/I/51KcqFWBdhL._AC_SY695_.jpg", 
                Price = 750,
                Amount = 3,
            },
            new Product 
            { 
                Id = 9, 
                Name = "Zapatos de godin", 
                Description = "Zapatos para ganar sueldo minimo y trabar como burro de carga", 
                Image = "https://media.gotrendier.mx/media/p/2022/02/07/n_62656cf8-8848-11ec-8091-026295ecb39b.jpeg", 
                Price = 150,
                Amount = 9999,
            },
            new Product 
            { 
                Id = 10, 
                Name = "Zapatillas de plumas", 
                Description = "Zapatillas que utilizaria peso pluma si fuera trans", 
                Image = "https://conideade.com/blog/wp-content/uploads/2014/08/zapato-decorado-con-pluma.jpg", 
                Price = 999999,
                Amount = 1,
            },
            new Product 
            { 
                Id = 11, 
                Name = "Alv que es esto", 
                Description = "Botas altotas rosas", 
                Image = "https://m.media-amazon.com/images/I/410gwyM1sFL._AC_SY695_.jpg", 
                Price = 999,
                Amount = 4,
            }
            
        );
    }
}