using System;
using System.Collections.Generic;
using System.Linq;
// Find if a key exists and return value safely
// 👉 Expectation: Use TryGetValue
class TryGetValue
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
        
        string key = "G";
        
        // Find if a key exists and return value safely
        if(data.TryGetValue(key, out var value))
        { Console.WriteLine($"{value}");}
        else
        {Console.WriteLine("not exist"); }

    }
}