using System;
using System.Collections.Generic;
class Password
{
    Password()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> s = new List<string>();
        while (n-- > 0)
        {
            string str = Console.ReadLine();
            if (s.Contains(str))
            {
                Console.WriteLine(str.Length + " " + str[str.Length / 2]);
                break;
            }
            char[] sc = str.ToCharArray();
            Array.Reverse(sc);
            str = new string(sc);
            s.Add(str);
        }
    }
}