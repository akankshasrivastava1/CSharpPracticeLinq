using System;

public class NegativeToPositive
{
    public static void Main(string[] args)
    {
        int[] arr =  {-2,-1,3,-5,6,4};
        for(int i =0; i<arr.Length; i++)
        {
            int result;
            if(arr[i] < 0)
            {
                result = arr[i] * -1;
            }
            else
            {
                result = arr[i];
            }
            Console.Write(" "+result);
        }
    }
}