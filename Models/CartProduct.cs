namespace Store.Models;

public class CartProduct
{
    public required int Id { get; set; }
    public required int UserId { get; set; }
    public required int ProductId { get; set; }
    public required int Amount { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}