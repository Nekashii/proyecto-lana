namespace Store.Models;

public class User
{
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required bool Admin { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}