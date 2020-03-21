using System;
using System.Collections.Generic;
class Acronym
{
    Acronym()
    {
        List<string> hatedWords = new List<string>();
        int k = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            hatedWords.Add(Console.ReadLine());
        }
        int n = Convert.ToInt16(Console.ReadLine());
        string[] sentence = Console.ReadLine().Split(' ');
        string op = string.Empty;
        foreach (var item in sentence)
        {
            if (!hatedWords.Contains(item))
                op += (item[0].ToString().ToUpper() + ".");
        }
        Console.Write(op.Substring(0, op.Length - 1));
    }
}
