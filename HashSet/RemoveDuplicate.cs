using System;
using System.Collections.Generic;

//int[] arr = {1,2,3,4,5,1};
// Output: true

public class RemoveDuplicate
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,2,4,4,6};

        var seen = new HashSet<int>();
        
        for(int i =0; i<arr.Length; i++)
        {
            if(seen.Add(arr[i]))
            {
               Console.WriteLine(arr[i]);
            }
        }
    }
}


public class RemoveDuplicate1
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,2,4,5,7,7};

        var seen = new HashSet<int>(arr);
        foreach(int num in seen)
        {
            Console.WriteLine(num);
        }

    }
}

// HashSet<int> seen = new HashSet<int>(arr);

// is same as below code

// HashSet<int> seen = new HashSet<int>();

// foreach (int num in arr)
// {
//     seen.Add(num);
// }