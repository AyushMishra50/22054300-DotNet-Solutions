using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Linear Search by Product Name
        Product? LinearSearch(List<Product> products, string name)
        {
            foreach (var product in products)
            {
                if (product.PName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        // Binary Search by Product Name (requires sorted list)
        Product? BinarySearch(List<Product> products, string name)
        {
            int left = 0, right = products.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(products[mid].PName, name, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return products[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }

        List<Product> products = new List<Product>
        {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Mobile", "Electronics"),
            new Product(3, "Shoes", "Footwear"),
            new Product(4, "Book", "Education")
        };

        Console.WriteLine("Enter product name to search:");
        string nameToSearch = Console.ReadLine();
        Product linearResult = LinearSearch(products, nameToSearch);
        Console.WriteLine(linearResult != null ? $"Found using Linear: {linearResult.PName}" : "Not found using Linear");
        products.Sort((p1, p2) => string.Compare(p1.PName, p2.PName, StringComparison.OrdinalIgnoreCase));
        Product binaryResult = BinarySearch(products, nameToSearch);
        Console.WriteLine(binaryResult != null ? $"Found using Binary: {binaryResult.PName}" : "Not found using Binary");
    }
}