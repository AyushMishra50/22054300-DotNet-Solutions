using RetailInventory.Models;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // Seed only if no categories exist
        if (!context.Categories.Any())
        {
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

            await context.Products.AddRangeAsync(product1, product2);

            await context.SaveChangesAsync();
            Console.WriteLine("✅ Initial data inserted successfully.");
        }
        else
        {
            Console.WriteLine("ℹ️ Data already exists. No changes made.");
        }
    }
}
