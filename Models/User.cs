using System.ComponentModel.DataAnnotations;

namespace Store.Models;

public class User
{
    public int Id { get; set; }
    [MaxLength(255)] public required string FirstName { get; set; }
    [MaxLength(255)] public required string LastName { get; set; }
    [MaxLength(255)] public required string Email { get; set; }
    [MaxLength(255)] public required string Password { get; set; }
    public required bool Admin { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}