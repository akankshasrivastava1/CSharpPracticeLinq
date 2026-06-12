using System;
// sort array without using inbuilt
public class SortArray
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 4, 3, 8, 5 };

        for (int i = 0; i < arr.Length; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                if(arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        foreach(var num in arr)
        {
            Console.WriteLine(num);
        }
    }
}


public class SortArray1
{
    public static void Main(string[] args)
    {
        int[] arr = {2,4,3,5,7,6};

        for(int i =0; i<arr.Length; i++)
        {
            for(int j = i+1; j<arr.Length; j++)
            {
                if(arr[i]> arr[j])
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