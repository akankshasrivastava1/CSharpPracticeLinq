1. LINQ TO OBJECTS
LINQ to Objects means querying in‑memory collections like arrays, lists, dictionaries.

List<int> numbers = new List<int> { 23, 34, 43, 12, 56 };

var evenNumbers = numbers.Where(n => n % 2 == 0);

foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}

