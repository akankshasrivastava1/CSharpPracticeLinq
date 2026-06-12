using System;
using System.Linq;
using System.Collections.Generic;

public class RemoveDuplicat
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,2,3,4,4,5};
        int index =1;
        
         for(int i =0; i<arr.Length; i++)
        {
            bool found = false;
            for(int j = i+1; j < arr.Length; j++)
            {
                if(arr[i] == arr[j])
                {
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine(" "+arr[i]);
            }
        }
    }
}

public class Another
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,2,3,4,4,5};
        int index =1;
        
        for(int i=1; i<arr.Length; i++)
        {
            if(arr[i] != arr[i-1])
            {
                arr[index++] = arr[i];
            }
        }
        for(int i =0; i<index; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}