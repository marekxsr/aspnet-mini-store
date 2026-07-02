using Microsoft.AspNetCore.Mvc.RazorPages;
using Application.Models;

namespace Application.Pages;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; } = new();

    public void OnGet()
    {
        Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Phone", Price = 800 },
            new Product { Id = 3, Name = "Headphones", Price = 150 }
        };
    }
}