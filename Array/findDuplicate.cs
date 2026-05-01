using System;
// find duplicate
public class FindDuplicate
{
    public static void Main(string[] args)
    {
        int[] arr =  {1, 2, 3, 2, 4, 1, 5};
        for(int i =0; i<arr.Length; i++)
        {
            for(int j = i+1; j < arr.Length; j++)
            {
                if(arr[i] == arr[j])
                {
                    Console.Write(" "+arr[i]);
                }
            }
        }
    }
}

//using HashSet

// using System;
// using System.Collections.Generic;
// // find duplicate
// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         int[] arr =  {1, 2, 3, 2, 4, 1, 5};
        
//         var seen = new HashSet<int>();
//         foreach (int x in arr)
//         {
//             if (!seen.Add(x))
//             {
//             Console.WriteLine("Duplicate: " + x);
//             break;
//             }
//         }
//     }
// }

// Using Linq

// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, 2, 4, 1, 5 };

//         var duplicates = arr
//             .GroupBy(x => x)
//             .Where(g => g.Count() > 1)
//             .Select(g => g.Key);
            
//             foreach (var d in duplicates)
//             Console.WriteLine("Duplicate: " + d);
//     }
// }