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

        // 🔹 Retrieve All Products Before
        Console.WriteLine("\n📦 Products Before Changes:");
        var productsBefore = await context.Products.ToListAsync();
        foreach (var p in productsBefore)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        // ✏️ Update Product Price
        var laptop = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
        if (laptop != null)
        {
            laptop.Price = 70000;
            await context.SaveChangesAsync();
            Console.WriteLine("\n✅ Laptop price updated to ₹70000.");
        }

        // ❌ Delete Discontinued Product
        var riceBag = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
        if (riceBag != null)
        {
            context.Products.Remove(riceBag);
            await context.SaveChangesAsync();
            Console.WriteLine("\n🗑️ Rice Bag deleted from database.");
        }

        // 🔁 Retrieve All Products After Changes
        Console.WriteLine("\n📦 Products After Changes:");
        var productsAfter = await context.Products.ToListAsync();
        foreach (var p in productsAfter)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }
    }
}
