namespace Store.Models;

public class Order
{
    public required int Id { get; set; }
    public required int UserId { get; set; }
    public IList<OrderProduct> Products { get; set; } = new List<OrderProduct>();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}