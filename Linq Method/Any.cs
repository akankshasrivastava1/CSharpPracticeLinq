// The Any method in LINQ is used to determine if a sequence contains any elements or if any element 
// satisfies a given condition. It returns a boolean and stops evaluating as soon as the result is known,
//  making it efficient for existence checks.

using System;
using System.Linq;
class Program14
{
   static void Main()
   {
       int[] numbers = { 10, 20, 60, 40 };
       bool hasLargeNumber = numbers.Any(n => n > 50);
       Console.WriteLine($"Any number > 50? {hasLargeNumber}"); // Output: True
   }
}