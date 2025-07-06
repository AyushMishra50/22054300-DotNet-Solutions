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

        // 🔍 Filter and Sort Products (Price > 1000, Descending)
        Console.WriteLine("\n📊 Filtered and Sorted Products (Price > ₹1000):");
        var filtered = await context.Products
            .Where(p => p.Price > 1000)
            .OrderByDescending(p => p.Price)
            .ToListAsync();

        foreach (var p in filtered)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        // 📦 Project into DTO (anonymous type)
        Console.WriteLine("\n🧾 Product DTOs (Name & Price only):");
        var productDTOs = await context.Products
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();

        foreach (var dto in productDTOs)
        {
            Console.WriteLine($"Name: {dto.Name}, Price: ₹{dto.Price}");
        }
    }
}
