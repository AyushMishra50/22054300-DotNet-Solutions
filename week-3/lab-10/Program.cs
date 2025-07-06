using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // 🔹 Eager Loading: Loads related Category with each Product
        Console.WriteLine("\n📦 Eager Loading:");
        var eagerLoaded = await context.Products
            .Include(p => p.Category)
            .ToListAsync();

        foreach (var p in eagerLoaded)
        {
            Console.WriteLine($"{p.Name} ({p.Category?.Name}) - ₹{p.Price}");
        }

        // 🔹 Explicit Loading: Manually load related data after querying the entity
        Console.WriteLine("\n📦 Explicit Loading:");
        var firstProduct = await context.Products.FirstOrDefaultAsync();
        if (firstProduct != null)
        {
            await context.Entry(firstProduct).Reference(p => p.Category).LoadAsync();
            Console.WriteLine($"{firstProduct.Name} belongs to {firstProduct.Category?.Name}");
        }

        // 🔹 Lazy Loading (requires additional setup)
        Console.WriteLine("\nℹ️ Lazy Loading: Enable in AppDbContext and make navigation properties 'virtual'");
        Console.WriteLine("    → Install Microsoft.EntityFrameworkCore.Proxies");
        Console.WriteLine("    → Use UseLazyLoadingProxies() in OnConfiguring()");
        Console.WriteLine("    → Make navigation property: public virtual Category? Category { get; set; }");
    }
}
