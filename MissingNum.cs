using System;
using System.Linq;

public class HelloWorld1
{
    public static void Main(string[] args)
    {
        int[] arr = { 11, 14, 8, 19, 20 };
        int n = 20;

        var missingNumbers =
            Enumerable.Range(1, n)
                      .Except(arr);

        foreach (int num in missingNumbers)
        {
            Console.Write(" " + num);
        }
    }
}
//using System;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         int[] arr = {11, 14, 8, 19, 20};
//         int n = 20;
//         bool[] found = new bool[n+1];
        
//         for(int i =0; i<arr.Length; i++)
//         {
//            found[arr[i]] = true;
//         }
        
//         for(int i = 1; i <= n; i++)
//         {
//              if(!found[i])
//             {
//                 Console.Write(" "+i);
//             }
            
//         }
//     }
// }
