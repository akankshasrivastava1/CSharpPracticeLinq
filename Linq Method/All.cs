// The All method in LINQ is used to determine whether all elements in a sequence satisfy a specified condition.
// It returns a boolean (true or false).

using System;
using System.Linq;
using System.Collections.Generic;

class Program12
{
    static void Main()
    {
        var numbers = new List<int> { 2, 4, 6, 8 };

        bool allPositive = numbers.All(n => n > 0);

        Console.WriteLine($"All numbers are positive: {allPositive}");
    }
}