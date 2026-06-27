using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        var nums = new List<int> { 1, 2, 2, 3, 3, 3, 4 };

        var result = nums
            .GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }

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