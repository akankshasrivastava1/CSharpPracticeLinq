using System;

// output country my is India;
public class HelloWorlRevers
{
    public static void Main(string[] args)
    {
        string input = "India is my country";
        string[] word =  input.Split(' ');
        Array.Reverse(word);
        string output = string.Join(" ",word);
        Console.WriteLine(output);
        
    }
}