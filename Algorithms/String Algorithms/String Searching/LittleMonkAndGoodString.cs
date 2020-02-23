using System;
class LittleMonkAndGoodString
{
    LittleMonkAndGoodString()
    {
        string str = Console.ReadLine();
        int count = 0, maxLength = 0;
        string vowels = "aeiou";
        foreach (char c in str)
        {
            if (vowels.Contains(c + ""))
                count++;
            else
            {
                if (count > maxLength)
                    maxLength = count;
                count = 0;
            }
        }
        Console.Write(maxLength > count ? maxLength : count);
    }
}