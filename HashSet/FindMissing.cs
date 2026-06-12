using System;
using System.Collections.Generic;

//int[] arr = {1,2,4,5,7};
// Output: 3,6


public class FindMissing
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,4,5,7};
        int n = 7;
        
        var seen = new HashSet<int>(arr);
        
        for(int i = 1; i<=n; i++)
        {
           if(!seen.Contains(i))
           {
            Console.WriteLine(i);
           }
        }
    }
}