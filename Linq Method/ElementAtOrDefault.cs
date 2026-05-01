// The ElementAtOrDefault method in LINQ is used to retrieve an element at a specified index from a sequence, but without throwing an 
// exception if the index is out of range.
// Instead, it returns the default value for the element type (null for reference types, 0 for numeric
//  value types, false for bool, etc.).


using System;
using System.Collections.Generic;
using System.Linq;

class Program5
{
    static void Main()
    {
        var names = new List<string> { "Alice", "Bob", "Charlie" };

        // Get element at index 1
        string name1 = names.ElementAtOrDefault(1);
        Console.WriteLine(name1); // Output: Bob

        // Try to get element at index 5 (out of range)
        string name2 = names.ElementAtOrDefault(5);
        Console.WriteLine(name2 == null ? "null" : name2); // Output: null

        // Example with value types
        var numbers = new List<int> { 10, 20, 30 };
        int num = numbers.ElementAtOrDefault(10); // Out of range
        Console.WriteLine(num); // Output: 0 (default for int)
    }
}