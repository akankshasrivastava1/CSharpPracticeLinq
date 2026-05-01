using System;
using System.Linq;
using System.Collections.Generic;

using static System.Console;

namespace LINQDemo
{
    class Employee
    {
        public string? Name { get; set; }
        public string? Department { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            var employees = new List<Employee>() {
                new Employee { Name = "John", Department = "HR", Salary = 50000 },
                new Employee { Name = "Jane", Department = "IT", Salary = 60000 },
                new Employee { Name = "Bob", Department = "HR", Salary = 45000 },
                new Employee { Name = "Sara", Department = "IT", Salary = 55000 },
                new Employee { Name = "Tom", Department = "IT", Salary = 65000 }
            };

            var salary = employees
            .Select(e => e.Salary)
            .OrderByDescending(s => s)
            .Distinct()
            .Skip(1)
            .FirstOrDefault();

            WriteLine($"{salary}");

        }
    }
}

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
//Top 2 salaries per department from Employees table


// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Employee
// {
//     public int Salary { get; set; }
//     public string Department { get; set; }
//     public string Name { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         var employees = new List<Employee>
//         {
//             new Employee { Department = "HR", Salary = 50000 },
//             new Employee { Department = "IT", Salary = 60000 },
//             new Employee { Department = "IT", Salary = 50000 },
//             new Employee { Department = "HR", Salary = 70000 },
//             new Employee { Department = "IT", Salary = 80000 }
//         };

//         var result = employees
//             .GroupBy(e => e.Department)
//             .SelectMany(g =>
//                 g.OrderByDescending(e => e.Salary)
//                  .Take(2)
//             );

//         foreach (var e in result)
//         {
//             Console.WriteLine($"{e.Department} -> {e.Salary}");
//         }
//     }
// }