using System.ComponentModel.DataAnnotations;

namespace Store.Models;

public class OrderProduct
{
    public int Id { get; set; }
    public required Product Product { get; set; }
    [Range(0, int.MaxValue)] public required double Price { get; set; }
    [Range(0, int.MaxValue)] public required int Amount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}