// The ToDictionary method in LINQ is used to convert an IEnumerable<T> (like a list, array, 
//or query result) into a Dictionary<TKey, TValue> by specifying how to select the key and value 
//for each element.
// It’s part of the System.Linq namespace.

using System;
using System.Collections.Generic;
using System.Linq;
class Program13
{
    public class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }
    static void Main()
    {
        var fruits = new List<string> { "Apple", "Banana", "Cherry" };

        // Convert to dictionary where key = fruit name, value = length of name
        Dictionary<string, int> fruitDict = fruits.ToDictionary(
            fruit => fruit,           // Key selector
            fruit => fruit.Length     // Value selector
        );

        foreach (var kvp in fruitDict)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }
        
        var products = new List<Product>
       {
           new Product { ID = 1, Name = "Mobile" },
           new Product { ID = 2, Name = "Laptop" },
           new Product { ID = 3, Name = "Tablet" }
       };
        // Convert list to dictionary: Key = ID, Value = Name
        var productDict = products.ToDictionary(p => p.ID, p => p.Name);
        foreach (var kvp in productDict)
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }
}