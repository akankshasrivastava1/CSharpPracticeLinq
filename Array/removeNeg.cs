using System;
using System.Linq;
using System.Collections.Generic;

public class RemoveNegative
{
    public static void Main(string[] args)
    {
        int[] arr = {-2,4,3,-5,7,-6};
        
        
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i]<0)
            {
                arr[i] = -arr[i];
            }
        }

        for(int i =0; i<arr.Length; i++)
        {
            for(int j = i+1; j<arr.Length; j++)
            {
                if(arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            Console.WriteLine(arr[i]);
        }
    }
}

//output: 2,3,4,5,6,7