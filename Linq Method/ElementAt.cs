//The ElementAt method in LINQ is used to retrieve the element at a specific zero-based index from a sequence (IEnumerable<T>).

using System;
using System.Linq;
using System.Collections.Generic;

class Program4
{
    static void Main()
    {
        // Data source
        var numbers = new List<int> { 10, 20, 30, 40, 50 };
        // Retrieve the element at index 2

        int element = numbers.ElementAt(2);
        Console.WriteLine($"The element at index 2 is: {element}");

        var fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };

        try
        {
            // Get the element at index 2 (zero-based)
            string fruit = fruits.ElementAt(2);
            Console.WriteLine($"Element at index 2: {fruit}");

            // Attempting to access an invalid index
            string invalidFruit = fruits.ElementAt(10); // Will throw exception
            Console.WriteLine(invalidFruit);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}