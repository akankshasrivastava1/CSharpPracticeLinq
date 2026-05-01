// using System.Linq;
// class Program
// {
//     static void Main(string[] args)
//     {
//         int [] age = { 20, 25, 30, 35, 40, 23, 26, 32, 29 };

//         // method expression
//         //  var result = age.Where(a => a > 30);

//         // query expression
//         var result = from a in age where a > 30 select a;
        
//          foreach (var item in result)
//          {
//              Console.Write(item + " ");
//          }
//         Console.WriteLine("Hello, World!");
//     }
// }
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

public class Program1
{
    public static void Main(string[] args)
    {
        string folderpath = @"C:\Users\asriva69\CSharpPracticeLinq";
        
        DateTime limit = DateTime.Now.AddHours(-24);
        
        var recentFiles = Directory.GetFiles(folderpath).Where(file => File.GetCreationTime(file) >= limit);
        
        
       Console.WriteLine("Files created in the last 24 hours:");

        foreach (var file in recentFiles)
        {
            Console.WriteLine($"{Path.GetFileName(file)}  -  Created: {File.GetCreationTime(file)}");
        }
    }
}