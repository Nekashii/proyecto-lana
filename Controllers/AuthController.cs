using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public AuthController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginCredentials credentials)
    {
        var users = _dbContext.Users!;
        var user = users.SingleOrDefault(user =>
            user.Email.ToLower() == credentials.Email.ToLower() && user.Password == credentials.Password);
        if (user == null) return NotFound();
        return Ok(user);
    }
}