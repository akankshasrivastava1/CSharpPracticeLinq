//The Contains method in LINQ is used to check whether a sequence (like an array, list, or any 
//IEnumerable<T>) contains a specific element.
// It works with:
// Default equality comparer (for primitive types like int, string, etc.).
// Custom equality comparer (for complex types).

using System;
using static System.Console;
class Program7
{
   static void Main()
   {
       string str = "bank server down try again";
       var result = str.Contains("bank");
       WriteLine($"{result}");
   }
}