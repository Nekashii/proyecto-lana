namespace Store.Models;

public class Order
{
    public int Id { get; set; }
    public required User User { get; set; }
    public IList<OrderProduct> Products { get; set; } = new List<OrderProduct>();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}