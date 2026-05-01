// Given a list of students {Name, Marks}, return only students with marks > 60.

using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string? name { get; set;}
    public int marks { get; set;}
    
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { name= "ram" , marks= 77},
            new Student { name= "eva" , marks= 45},
            new Student { name= "lily" , marks= 57},
            new Student { name= "sam" , marks= 67},
            new Student { name= "hari" , marks= 86}
        };
        
       var result =  students.Where(s=> s.marks > 60);
       
       foreach(var item in result)
       {
           Console.WriteLine($"{item.name} - {item.marks}");
       }       
    }
}