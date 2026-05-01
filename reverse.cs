using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld3
{
    public static void Main(string[] args)
    {
        var str = "C# programming language";
        string reversed = new string(str.Reverse().ToArray());
        Console.WriteLine(String.Join(',',reversed));
        Console.WriteLine(String.Join(" ",str.Split(' ').Reverse()));
    }
}