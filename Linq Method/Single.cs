// The Single method in LINQ is used to retrieve a single element from a sequence. It throws an 
//exception if the sequence contains no elements or more than one element. This is particularly
// useful when you are certain that the query will return exactly one record.

using System;
using System.Linq;
class Program9
{
   static void Main()
   {
       var products = new[]
       {
           new { Id = 1, Name = "Apple" },
           new { Id = 2, Name = "Banana" }
       };
       // Retrieve the product with Id = 1
       var product = products.Single(p => p.Id == 1);
       Console.WriteLine(product.Name); // Output: Apple
   }
}