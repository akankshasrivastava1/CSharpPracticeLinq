using System;

// reverse string without changing the place
class reverseSamePlace
{
    static void Main()
    {
        string input = "This is dog";
        string[] word = input.Split(' ');
        
        for(int i=0; i<word.Length; i++)
        {
            char[] ch = word[i].ToCharArray();
            Array.Reverse(ch);
            word[i] = new string(ch);
        }
        
        foreach(var words in word)
        {
            Console.Write(" "+words);
        }
        
    }
}