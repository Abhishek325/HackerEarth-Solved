using System;
class AliceAndStrings
{
    AliceAndStrings()
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("NO");
            return;
        }
        int diff, prev = Math.Abs(str1[0] - str2[0]);
        for (int i = 1; i < str1.Length; i++)
        {
            diff = Math.Abs(str1[i] - str2[i]);
            if (Math.Abs(diff - prev) > 1 && diff > 0)
            {
                Console.WriteLine("NO");
                return;
            }
        }
        Console.WriteLine("YES");
    }
}