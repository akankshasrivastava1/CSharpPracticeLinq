//From a list of words, return the longest word.

// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class Words
// {
//     public string longestword { get; set;}
  
//     public static void Main(string[] args)
//     {
//         var word = new List<Words>
//         {
//             new Words {longestword = "ram" },
//             new Words {longestword = "evanam" },
//             new Words {longestword = "lilypod"},
//             new Words {longestword = "sam" },
//             new Words {longestword = "hari"}
//         };       
//  // Get the word with the maximum length
//         var result = word.OrderByDescending(w => w.longestword.Length).FirstOrDefault();       
//        Console.WriteLine($"{result.longestword}");
       
//     }
// }