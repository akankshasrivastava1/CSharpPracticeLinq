using System;
using System.Collections.Generic;
using System.Linq;
//Sort dictionary by value (ascending & descending)
class Order
{
    static void Main()
    {
        // Original dictionary
        var data = new Dictionary<string, int>()
        {
            {"A", 40},
            {"B", 60},
            {"C", 80},
            {"D", 20},
            {"E", 55}
        };

        // Filter dictionary where value > 50
        var filteredDict = data
            .ToDictionary(x => x.Key, x => x.Value)
            .OrderByDescending(x => x.Value);

        // Print result
        foreach (var item in filteredDict)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}