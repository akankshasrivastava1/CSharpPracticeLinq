using System;
using System.Linq;
using System.Collections.Generic;

// Left Join using Linq

public class Employees
{
    public int EmpId {get; set;}
    public int DeptId {get; set;}
}

public class Departments
{
    public int DeptId {get; set;}
    public string Name {get; set;}
}

public class Hello{
    

    public static void Main(string[] args)
    {
        var employee = new List<Employees>()
        {
            new Employees { EmpId = 1, DeptId = 1 },
            new Employees { EmpId = 2, DeptId = 2 },
            new Employees { EmpId = 3, DeptId = 3 }
        };
        
         var department = new List<Departments>()
        {
            new Departments { DeptId = 1, Name = "IT" },
            new Departments { DeptId = 2, Name = "HR" }
        };
        
        var leftJoin = employee.GroupJoin(department,
        e => e.DeptId, d => d.DeptId, 
        (e, dgroup) => new {
            EmpId = e.EmpId,
            DeptName = dgroup.FirstOrDefault()?.Name ?? "Null"
        }).DefaultIfEmpty();
        
        foreach(var item in leftJoin)
        {
            Console.WriteLine($"{item.EmpId} -> {item.DeptName}");
            
        }
        //Console.WriteLine (String.Join(',',leftJoin));
    }

}