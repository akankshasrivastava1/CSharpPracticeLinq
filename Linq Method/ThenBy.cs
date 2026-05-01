// The ThenBy method in LINQ is used to perform a secondary sort on a sequence that has already been 
// ordered using OrderBy or OrderByDescending.
// It is part of the System.Linq namespace and works on sequences implementing IOrderedEnumerable<T>.


using System;
using System.Linq;
using System.Collections.Generic;

class Program15
{
    class Student
    {
        public string? Name { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        // Sample data
        var students = new List<Student>
        {
            new Student { Name = "Amit", Grade = 90, Age = 20 },
            new Student { Name = "Ravi", Grade = 85, Age = 22 },
            new Student { Name = "Amit", Grade = 90, Age = 19 },
            new Student { Name = "Neha", Grade = 85, Age = 21 }
        };

        // Primary sort by Name, secondary sort by Age
        var sortedStudents = students
            .OrderBy(s => s.Name)       // Primary sort
            .ThenBy(s => s.Age);        // Secondary sort

        // Display results
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.Name} - Grade: {student.Grade}, Age: {student.Age}");
        }
    }
}

