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

// using System;
// using System.Collections.Generic;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         //if (dict.ContainsKey("apple"))
//         var dict = new Dictionary<string, int>()
//         {
//             {"Hello my name is akanksha", 1}
//         };
        
//         foreach (var key in dict.Keys)
//         {
//             if (key.Contains("akanksha"))
//             {
//                 Console.WriteLine("Found in key");
//                 return;
//             }
//         }
//         Console.WriteLine("Not found");
//     }
//}