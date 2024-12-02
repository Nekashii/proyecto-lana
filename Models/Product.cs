using System.ComponentModel.DataAnnotations;

namespace Store.Models;

public class Product
{
    public int Id { get; set; }
    [MaxLength(255)] public required string Name { get; set; }
    [MaxLength(255)] public required string Description { get; set; }
    [MaxLength(1023)] public required string Image { get; set; }
    [Range(0, int.MaxValue)] public required double Price { get; set; }
    [Range(0, int.MaxValue)] public required int Amount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}