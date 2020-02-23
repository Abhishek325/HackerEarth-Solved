using System;
using System.Collections;
class String
{
    String()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string str = Console.ReadLine();
        int min = n;
        ArrayList dp = new ArrayList();
        foreach (char c in str)
        {
            if (!dp.Contains(c))
            {
                int newLength = str.Replace(c + "", "").Length;
                if (newLength < min)
                    min = newLength;
                dp.Add(c);
            }
        }
        Console.WriteLine(min);
    }
}
