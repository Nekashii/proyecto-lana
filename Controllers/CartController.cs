using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Controllers;

[Route("[controller]/{userId:int}")]
public class CartController(ApplicationDbContext dbContext) : ControllerBase
{
    [HttpGet("")]
    public IActionResult Get([FromRoute] int userId)
    {
        var cartProducts = dbContext.CartProducts!;
        return Ok(cartProducts.Where(cartProduct => cartProduct.UserId == userId)
            .Include(cartProduct => cartProduct.Product));
    }

    [HttpPost("{productId:int}")]
    public IActionResult AddProduct([FromRoute] int userId, [FromRoute] int productId)
    {
        var products = dbContext.Products!;
        var cartProducts = dbContext.CartProducts!;
        var product = products.SingleOrDefault(product => product.Id == productId);
        if (product == null) return NotFound();
        var cartProduct =
            cartProducts.SingleOrDefault(cartProduct =>
                cartProduct.UserId == userId && cartProduct.Product.Id == productId);
        if (cartProduct == null)
        {
            cartProducts.Add(new CartProduct { UserId = userId, Product = product });
        }
        else
        {
            if (cartProduct.Amount >= product.Amount) return BadRequest();
            cartProduct.Amount++;
            cartProducts.Update(cartProduct);
        }

        dbContext.SaveChanges();
        return Ok();
    }

    [HttpDelete("{productId:int}")]
    public IActionResult RemoveProduct([FromRoute] int userId, [FromRoute] int productId)
    {
        var cartProducts = dbContext.CartProducts!;
        var cartProduct =
            cartProducts.SingleOrDefault(cartProduct =>
                cartProduct.UserId == userId && cartProduct.Product.Id == productId);
        if (cartProduct == null) return NotFound();
        cartProducts.Remove(cartProduct);
        dbContext.SaveChanges();
        return Ok();
    }
}