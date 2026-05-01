// //Sort a list of employees by salary (ascending & descending).


// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class Salary
// {
//     public int salaries { get; set;}
   
//     public static void Main(string[] args)
//     {
//         List<Salary> salary = new List<Salary>
//         {
//             new Salary {salaries = 30000},
//             new Salary {salaries = 80000},
//             new Salary {salaries = 67999},
//             new Salary {salaries = 78000},
//             new Salary {salaries = 66999}
//         };
        
//         var ascend = salary.OrderBy(s => s.salaries);
//         var descen = salary.OrderByDescending(s => s.salaries);

      
//         Console.WriteLine("Ascending:");
//         Console.WriteLine(string.Join(", ",ascend.Select(s=>s.salaries)));

//         Console.WriteLine("\nDescending:");
//         Console.WriteLine(string.Join(", ",ascend.Select(s =>s.salaries)));
//     }
// }