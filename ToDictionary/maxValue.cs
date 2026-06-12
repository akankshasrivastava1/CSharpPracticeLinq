using System;
using System.Collections.Generic;
using System.Linq;

class MaxValue
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
        
       // Find max value from dictionary
       var maxValue = data
           .OrderByDescending(x=>x.Value)
           .First();
        
        Console.WriteLine($"{maxValue.Value}");
        
    }
}