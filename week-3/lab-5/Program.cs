using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // 🔹 Retrieve All Products
        Console.WriteLine("\n📦 All Products:");
        var products = await context.Products.ToListAsync();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        // 🔍 Find a product by ID
        Console.WriteLine("\n🔍 Find by ID (Id = 1):");
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"Found: {product?.Name}");

        // 💰 Find first expensive product
        Console.WriteLine("\n💰 First Expensive Product (Price > ₹50000):");
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"Expensive: {expensive?.Name ?? "None"}");
    }
}
