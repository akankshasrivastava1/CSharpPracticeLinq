using System;
using System.Collections.Generic;

//int[] arr = {1,2,3,4,5,1};
// Output: true

public class CheckDuplicate
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,2,4,4,6};
        bool found = false;

        var seen = new HashSet<int>();
        
        for(int i =0; i<arr.Length; i++)
        {
            if(seen.Contains(arr[i]))
            {
               found = true;
               break;
            }
            else {
                seen.Add(arr[i]);
            }
        }
        Console.WriteLine(found);
    }
}


