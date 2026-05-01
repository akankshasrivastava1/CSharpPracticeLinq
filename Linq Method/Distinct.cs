// The Distinct method in LINQ is used to remove duplicate elements from a sequence.
// It works on any collection that implements IEnumerable<T> and uses the default equality comparer unless you provide a custom one.

using System;
using System.Linq;
using System.Collections.Generic;
class Program3
{
   static void Main()
   {
       List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
       var distinctNumbers = numbers.Distinct();
       foreach (var num in distinctNumbers)
       {
           Console.WriteLine(num); // Output: 1, 2, 3, 4, 5
       }
   }
}