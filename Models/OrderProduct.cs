namespace Store.Models;

public class OrderProduct
{
    public required int Id { get; set; }
    public required Product Product { get; set; }
    public required double Price { get; set; }
    public required int Amount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}