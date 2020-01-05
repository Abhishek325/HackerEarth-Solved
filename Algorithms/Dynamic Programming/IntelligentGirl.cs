using System;
using System.Linq;
using System.Collections.Generic;

class IntelligentGirl
{
    IntelligentGirl()
    {
        string s = Console.ReadLine();
        List<int> evenIndex = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            int n = s[i] - '0';
            if (n % 2 == 0)
                evenIndex.Add(i);
        }
        for (int i = 0; i < s.Length; i++)
        {
            Console.Write(evenIndex.Count(x => x >= i) + " ");
        }
    }
}
