//The First method in System.Linq returns the first element of a sequence, or the first element 
//that satisfies a given condition. If no such element exists, it throws an InvalidOperationException.

using System;
using System.Linq;
using System.Collections.Generic;
class Program10
{
   static void Main()
   {
       List<int> numbers = new List<int> { 9, 34, 65, 92, 87 };
       // Get the first element
       int firstNumber = numbers.First();
       Console.WriteLine(firstNumber); // Output: 9
       // Get the first element greater than 80
       int firstGreaterThan80 = numbers.First(n => n > 80);
       Console.WriteLine(firstGreaterThan80); // Output: 92
   }
}