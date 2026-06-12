public class MissingNumber
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