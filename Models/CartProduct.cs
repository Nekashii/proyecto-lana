using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models;

public class CartProduct
{
    public int Id { get; set; }
    [ForeignKey("User")] public required int UserId { get; set; }
    public required Product Product { get; set; }
    [Range(0, int.MaxValue)] public int Amount { get; set; } = 1;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}