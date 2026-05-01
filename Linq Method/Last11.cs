// The Last<TSource> method in LINQ is used to retrieve the last element of a sequence. It is part of
//  the System.Linq namespace and works with any IEnumerable<T> collection.

using System;
using System.Linq;
class Program11
{
   static void Main()
   {
       int[] numbers = { 10, 20, 30, 40, 50 };
       int lastNumber = numbers.Last();
       Console.WriteLine(lastNumber); // Output: 50
   }
}