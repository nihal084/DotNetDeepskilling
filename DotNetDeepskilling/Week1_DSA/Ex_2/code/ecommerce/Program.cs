using System;
using ecommerce;

internal class NewBaseType
{
    static Product BinarySearch(Product[] products, int id)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == id)
                return products[mid];
            else if (products[mid].ProductId < id)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static Product LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }
    static void Main()
    {
        // Sample product list
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(205, "Shoes", "Fashion"),
            new Product(150, "Smartphone", "Electronics"),
            new Product(310, "Book", "Education")
        };

        // Linear Search by Name
        Console.WriteLine("🔍 Linear Search (by product name):");
        var foundByName = LinearSearch(products, "Shoes");

        if (foundByName != null)
            Console.WriteLine($"✅ Found: {foundByName.ProductName} in {foundByName.Category}");
        else
            Console.WriteLine("❌ Product not found by name.");

        // Binary Search needs products sorted by ID
        Array.Sort(products, (p1, p2) => p1.ProductId.CompareTo(p2.ProductId));

        // Binary Search by ID
        Console.WriteLine("\n⚡ Binary Search (by product ID):");
        var foundById = BinarySearch(products, 150);

        if (foundById != null)
            Console.WriteLine($"✅ Found: {foundById.ProductName} in {foundById.Category}");
        else
            Console.WriteLine("❌ Product not found by ID.");
    }
}