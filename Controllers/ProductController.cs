using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController(ApplicationDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var products = dbContext.Products!;
        return (Ok(products));
    }

    [HttpGet("available")]
    public IActionResult GetAvailable()
    {
        var products = dbContext.Products!;
        return (Ok(products.Where(product => product.Amount > 0)));
    }
}