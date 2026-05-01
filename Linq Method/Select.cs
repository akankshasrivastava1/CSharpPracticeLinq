using System;
using System.Linq;
using System.Collections.Generic;

// Introduction to the LINQ Select method
// The Select() method is a LINQ extension method. The Select() method projects or transforms each element of a sequence into a new form.
// The Select method in LINQ is used to project (transform) each element of a sequence into a new form.
// It’s part of the System.Linq namespace and works with any IEnumerable<T> or IQueryable<T> collection.


using static System.Console;

var greetings = new string[] { "hi","hello","hey", "howdy"};

var result = greetings.Select(
    s=>s[0].ToString().ToUpper() +s.Substring(1));

foreach (var item in result)
{
    WriteLine(item);
}

