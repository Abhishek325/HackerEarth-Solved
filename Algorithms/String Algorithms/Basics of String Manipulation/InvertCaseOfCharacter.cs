using System;
using System.Linq;
class InvertCaseOfCharacter
{
    public InvertCaseOfCharacter()
    {
        string str = Console.ReadLine();
        Int16[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt16(x)).ToArray();
        int n1 = input[0];
        int n2 = input[1];
        string res = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (i == (n1 - 1) || i == (n2 - 1))
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    res += (char)(str[i] + 32);
                }
                else if (str[i] >= 97 && str[i] <= 122)
                    res += (char)(str[i] - 32);
                else res += str[i];
            }
            else
                res += str[i];
        }
        Console.WriteLine(res);
    }
}
