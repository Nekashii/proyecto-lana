namespace Store.Models;

public class Order
{
    public required int Id { get; set; }
    public required int UserId { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}