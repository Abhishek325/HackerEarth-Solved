using System;
using System.Collections.Generic;
using System.Linq;
class RemoveDuplicates
{
    RemoveDuplicates()
    {
        string str = Console.ReadLine();
        List<char> traversed = new List<char>();
        foreach (char c in str)
        {
            if (traversed.Count(i => i == c) == 0)
                traversed.Add(c);
        }
        Console.WriteLine(string.Join("", traversed.ToArray()));
    }
}
