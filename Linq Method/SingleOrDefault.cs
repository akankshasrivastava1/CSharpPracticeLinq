// SingleOrDefault is a LINQ method used to retrieve exactly one element from a sequence or return
 //a default value if no element is found. If more than one element matches the criteria, it throws 
 //an InvalidOperationException, making it ideal for scenarios where uniqueness is expected.
// It has multiple overloads:


using System;
using System.Linq;
class Program8
{
   static void Main()
   {
       string[] fruits = { "apple", "banana", "mango" };
       // Expecting exactly one match
       string result1 = fruits.SingleOrDefault(f => f == "banana");
       Console.WriteLine(result1); // Output: banana
       // No match found
       string result2 = fruits.SingleOrDefault(f => f == "orange");
       Console.WriteLine(result2 ?? "No match"); // Output: No match
       // Multiple matches cause exception
       string[] dupes = { "apple", "apple" };
       try
       {
           var error = dupes.SingleOrDefault(f => f == "apple");
       }
       catch (InvalidOperationException ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}

