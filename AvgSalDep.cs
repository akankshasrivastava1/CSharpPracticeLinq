//Average salary per department
using System;
using System.Linq;
using System.Collections.Generic;

class EmployeeAvg
{
    public int Salary {get; set;}
    public string dept {get; set;}
}

public class AvgSalDep
{
    public static void Main(string[] args)
    {
        var employee = new List<Employee>()
        {
            new Employee {dept = "HR",Salary = 50000 },
            new Employee {dept = "IT", Salary = 60000 },
            new Employee {dept = "HR", Salary = 45000 },
            new Employee {dept = "IT", Salary = 55000 },
            new Employee {dept = "IT", Salary = 65000 },
            new Employee {dept = "Finance", Salary = 76000},
            new Employee {dept = "Finance", Salary = 39000},
            new Employee {dept = "Finance", Salary = 59000},
        };
        
        
        var topSal = employee
        .GroupBy(s=>s.dept)
        .Select(g=> new
        {
            dept = g.Key,
            AvgSalary = g.Average(s=>s.Salary)
        });
        
        foreach(var item in topSal)
        {
            Console.WriteLine($"{item.dept} - {item.AvgSalary}");
        }
        
        //  var topSal = employee
        // .Average(s=>s.Salary)
        // ;
        
        // Console.WriteLine(topSal);
    }
}