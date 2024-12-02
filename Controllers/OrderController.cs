using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Controllers;

[ApiController]
[Route(("[controller]"))]
public class OrderController(ApplicationDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var orders = dbContext.Orders!;
        return Ok(orders.Where(order => order.DeletedAt == null).OrderByDescending(order => order.CreatedAt)
            .Include(order => order.User)
            .Include(order => order.Products)
            .ThenInclude(product => product.Product));
    }

    [HttpGet("{userId:int}")]
    public IActionResult GetByUser([FromRoute] int userId)
    {
        var orders = dbContext.Orders!;
        return Ok(orders.Where(order => order.DeletedAt == null && order.User.Id == userId)
            .OrderByDescending(order => order.CreatedAt)
            .Include(order => order.Products).ThenInclude(product => product.Product));
    }

    [HttpPost]
    public IActionResult Create([FromBody] Order order)
    {
        var orders = dbContext.Orders!;
        var products = dbContext.Products!;
        dbContext.Attach(order.User);
        foreach (var orderProduct in order.Products)
        {
            var product = orderProduct.Product;
            dbContext.Attach(product);
            if (product.Amount < orderProduct.Amount) continue;
            product.Amount -= orderProduct.Amount;
            products.Update(product);
        }

        orders.Add(order);
        dbContext.SaveChanges();
        return Ok();
    }
}