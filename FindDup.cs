using System;
using System.Linq;
using System.Collections.Generic;

class FindDupli
{
    public int Salary {get; set;}
    public string dept {get; set;}
}

public class FindDup
{
    public static void Main(string[] args)
    {
        var findDuplicate = new List<FindDupli>()
        {
            new FindDupli {dept = "HR",Salary = 50000 },
            new FindDupli {dept = "IT", Salary = 60000 },
            new FindDupli {dept= "HR", Salary = 45000 },
            new FindDupli {dept = "IT", Salary = 55000 },
            new FindDupli {dept = "IT", Salary = 65000 },
            new FindDupli {dept = "Finance", Salary = 76000},
            // new FindDupli {dept = "Finance", Salary = 39000},
            // new FindDupli {dept = "Finance", Salary = 59000},
        };
        

         // find duplicate value
         var topSal = findDuplicate
        .GroupBy(e=>e.dept)
        .Where(g=>g.Count()>1)
        .Select(e=>e.Key);

        //unique value
        // var topSal = FindDupli
        // .Select(e=>e.dept)
        // .Distinct();
        
        foreach(var item in topSal)
        {
            Console.WriteLine(item);
        }
        
        
    }
}

// -- Duplicate name find
// SELECT name, COUNT(*)
// FROM employee
// GROUP BY name
// HAVING COUNT(*) > 1;