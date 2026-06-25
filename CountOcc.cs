using System;
using System.Linq;
using System.Collections.Generic;


public static void PrintElementCounts(List<int> nums)
{
   
}

    public static void Main(string[] args)
    {
        var nums = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
        PrintElementCounts(nums);
    }
public class HelloWorld
{
    public static void Main(string[] args)
    {
        var countOccurence = new List<string>{"apple", "apple", "kiwi", "berry", "orange", "mango"};
        
        var result = countOccurence.GroupBy(x=>x)
        .ToDictionary(i=>i.Key, i=>i.Count());
        //.Select(x=> new {Item = x.Key, Count= x.Count()});
        
        
        foreach(var item in result)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
            //Console.WriteLine($"{item.Item} : {item.Count}");
        }
    }
}

// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         var countOccurence = new List<string>
//         {
//             "apple", "apple", "kiwi", "berry", "orange", "mango"
//         };

//         var result = new Dictionary<string, int>();

//         foreach (var item in countOccurence)
//         {
//             result[item] = (result.ContainsKey(item) ?  result[item]+1 : 1);
//         }

//         foreach (var item in result)
//         {
//             Console.WriteLine($"{item.Key} : {item.Value}");
//         }
//     }
// }