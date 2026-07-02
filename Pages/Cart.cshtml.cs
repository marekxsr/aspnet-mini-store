using Microsoft.AspNetCore.Mvc.RazorPages;
using Application.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application.Pages;

public class CartModel : PageModel
{
    public static List<CartItem> Cart = new List<CartItem>();

    public void OnPost(int id)
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Phone", Price = 800 },
            new Product { Id = 3, Name = "Headphones", Price = 150 }
        };

        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return;

        var item = Cart.FirstOrDefault(x => x.Product.Id == id);

        if (item == null)
        {
            Cart.Add(new CartItem
            {
                Product = product,
                Quantity = 1
            });
        }
        else
        {
            item.Quantity++;
        }
    }

    public void OnGet() { }
}

public class CartItem
{
    public Product Product { get; set; } = default!;
    public int Quantity { get; set; }
}