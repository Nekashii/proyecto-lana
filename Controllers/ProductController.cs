using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController(ApplicationDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var products = dbContext.Products!;
        return Ok(products.OrderByDescending(product => product.CreatedAt));
    }

    [HttpGet("available")]
    public IActionResult GetAvailable()
    {
        var products = dbContext.Products!;
        return Ok(products.Where(product => product.Amount > 0).OrderByDescending(product => product.CreatedAt));
    }

    [HttpPost]
    public IActionResult Create([FromBody] Product product)
    {
        var products = dbContext.Products!;
        products.Add(product);
        dbContext.SaveChanges();
        return Ok();
    }
}