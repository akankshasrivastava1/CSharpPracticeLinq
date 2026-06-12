public class FindFirstDuplicate
{
    public static void Main(string[] args)
    {
        int[] arr = {2,1,3,5,3,2};

        var seen = new HashSet<int>();
        
        foreach(int num in arr)
        {
            if(!seen.Add(num))
            {
                 Console.WriteLine(num);
                 break;
            }
           
        }

    }
}