using System;
using System.Linq;
using System.Collections.Generic;

// find employee highest salary 
//Filter dictionary where value > 50000 and return new dictionary

class Employee {
    internal string dept;

    public string ? Name {get; set;}
    
    public int Salary {get; set;}
}
class Program1223
{
    static void Main()
    {
       var employee = new List<Employee>
       {
           new Employee{Name= "Akanksha", Salary= 85000},
           new Employee{Name= "Astha", Salary= 90000},
           new Employee{Name= "Alia", Salary= 50000},
           new Employee{Name= "Anisha", Salary= 50000},
       };
       
       var dict = employee
            .Where(x => x.Salary > 50000)
            .ToDictionary(x => x.Salary);

       foreach(var item in dict)
       {
           Console.WriteLine($"{item.Key}");
       }
    }
}

class Pro
{
    static void Main()
    {
        // Original dictionary
        var data = new Dictionary<string, int>()
        {
            {"A", 40},
            {"B", 60},
            {"C", 80},
            {"D", 20},
            {"E", 55}
        };

        // Filter dictionary where value > 50
        var filteredDict = data
            .Where(x => x.Value > 50)
            .ToDictionary(x => x.Key, x => x.Value);

        // Print result
        foreach (var item in filteredDict)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}
