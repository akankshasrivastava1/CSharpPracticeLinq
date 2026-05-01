using System;
using System.Linq;
using System.Collections.Generic;

class DictionaryDemo
{
    static void PrintDictionary(Dictionary<string, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }

    static void Main()
    {
        // 1️⃣ Create Dictionary with initial capacity (performance optimization)
        var fruits = new Dictionary<string, int>(5);

        Console.WriteLine("=== ADD / INDEXER ===");

        // 2️⃣ Add using Add()
        fruits.Add("apple", 2);
        fruits.Add("banana", 3);

        // 3️⃣ Add / Update using Indexer
        fruits["apple"] = 5;
        fruits["orange"] = 1;

        PrintDictionary(fruits);

        Console.WriteLine("\n=== ContainsKey ===");

        // 4️⃣ ContainsKey
        if (fruits.ContainsKey("banana"))
        {
            Console.WriteLine("banana exist");
        }

        Console.WriteLine("\n=== TryGetValue (Preferred) ===");

        // 5️⃣ TryGetValue (single lookup)
        if (fruits.TryGetValue("apple", out int appleCount))
        {
            Console.WriteLine($"Apple count = {appleCount}");
        }


        Console.WriteLine("\n=== ContainsValue ===");

        // 6️⃣ ContainsValue (O(n))
        if (fruits.ContainsValue(1))
        {
            Console.WriteLine("Some fruits has count 1");
        }


        Console.WriteLine("\n=== Count ===");

        // 7️⃣ Count
        Console.WriteLine($"Total item = {fruits.Count}");
        PrintDictionary(fruits);


        Console.WriteLine("\n=== Keys & Values ===");

        // 8️⃣ Keys
        Console.WriteLine("Keys:");
        //Console.WriteLine(String.Join("\n",fruits.Keys));
        foreach (var key in fruits.Keys)
        {
            Console.WriteLine(key);
        }

        // 9️⃣ Values
        Console.WriteLine("Values:");
        foreach (var value in fruits.Values)
        {
            Console.WriteLine(value);
        }


        Console.WriteLine("\n=== Remove ===");

        // 🔟 Remove
        bool removed = fruits.Remove("banana");
        Console.WriteLine($"banana removed {removed}");

        PrintDictionary(fruits);


        Console.WriteLine("\n=== TryAdd ===");

        // 1️⃣1️⃣ TryAdd (safe add)
        bool added = fruits.TryAdd("kiwi", 4);
        Console.WriteLine($"kiwi added {added}");

        // duplicate add
        added = fruits.TryAdd("apple", 8);
        Console.WriteLine($"apple added {added}");

        PrintDictionary(fruits);

        Console.WriteLine("\n=== Clear ===");

        // 1️⃣2️⃣ Clear
        fruits.Clear();
        Console.WriteLine($"Count after clear = {fruits.Count}");


    }


}