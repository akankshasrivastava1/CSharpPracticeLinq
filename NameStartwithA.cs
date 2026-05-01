// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class NameStartwithA
// {
//     public static void Main(string[] args)
//     {
//        var names = new List<string> {"ali", "alia", "adam", "ansh", "clay", "lily", "eva", "coco"};
        
//         var result = names.Where(name => name.StartsWith("a")).Select(name=>name);

//         //var result = from name in names where name.StartsWith("a") select name;
        
//         foreach(string item in result)
//         {
//             Console.Write(" "+ item);
//         }
//     }
// }