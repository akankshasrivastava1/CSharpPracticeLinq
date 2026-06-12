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

public class findFirstMissing
{
    public static void Main(string[] args)
    {
        int[] arr = {2,3,5,3,2};
        int n = 5;

       for(int i = 1; i<n; i++)
       {
           bool found = false;
           for(int j = 0; j<arr.Length; j++)
           {
               if(arr[j] == i)
               {
                   found = true;
                   break;
               }
           }
           if(!found)
           {
               Console.WriteLine(i);
               break;
           }
       }

    }
}

public class MissingNonMissing
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 4, 5, 7, 8, 9};
        int n = 10;
        
        for(int i=1; i<=n; i++)
        {
            bool found = false;
            for(int j=0; j<arr.Length; j++)
            {
                if(arr[j] == i)
                {
                    found = true;
                    break;
                }
            }
            if(!found || found)
            {
                Console.WriteLine(i);
            }
        }
    }
}
