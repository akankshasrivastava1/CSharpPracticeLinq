// The Where method in LINQ is used to filter a sequence based on a condition (predicate).
// It returns only those elements that satisfy the given condition.

using System;
using System.Linq;
using System.Collections.Generic;
class Program2
{
   static void Main()
   {
     var numbers = new List<int> { 1, 2, 3, 4, 5, 6 }; {

        // Filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }

       var fruits = new List<string>
       { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape" };
       var shortFruits = fruits.Where(fruit => fruit.Length < 6);
       foreach (var fruit in shortFruits)
           Console.WriteLine(fruit);
   }
}