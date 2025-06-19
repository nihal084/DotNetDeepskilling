using System;
using System.Linq;

// This class represents a product in our online shop
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        Id = id;
        Name = name;
        Category = category;
    }
}

public class SearchHelper
{
    public static Product SearchByNameLinear(Product[] inventory, string searchTerm)
    {
        foreach (var item in inventory)
        {
            if (item.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                return item;
        }
        return null;
    }
    public static Product SearchByNameBinary(Product[] sortedInventory, string searchTerm)
    {
        int low = 0, high = sortedInventory.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int cmp = string.Compare(sortedInventory[mid].Name, searchTerm, StringComparison.OrdinalIgnoreCase);
            if (cmp == 0)
                return sortedInventory[mid];
            else if (cmp < 0)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        Product[] inventory = new Product[]
        {
            new Product(101, "Smartphone", "Electronics"),
            new Product(102, "Running Shoes", "Footwear"),
            new Product(103, "Coffee Maker", "Home Appliances"),
            new Product(104, "Bluetooth Speaker", "Electronics"),
            new Product(105, "Desk Lamp", "Furniture")
        };

        var sortedInventory = inventory.OrderBy(p => p.Name).ToArray();

        string searchFor = "Bluetooth Speaker";
        Console.WriteLine($"Searching for '{searchFor}' using linear search:");
        var resultLinear = SearchHelper.SearchByNameLinear(inventory, searchFor);
        Console.WriteLine(resultLinear != null ? $"Found: {resultLinear.Name} ({resultLinear.Category})" : "Not found.");

        Console.WriteLine($"\nSearching for '{searchFor}' using binary search:");
        var resultBinary = SearchHelper.SearchByNameBinary(sortedInventory, searchFor);
        Console.WriteLine(resultBinary != null ? $"Found: {resultBinary.Name} ({resultBinary.Category})" : "Not found.");

        Console.WriteLine("\nNote: Linear search checks every product, while binary search is much faster for sorted lists!");
    }
}
