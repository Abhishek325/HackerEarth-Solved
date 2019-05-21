using System;
using System.Linq;

class DigitProblem
{
    public DigitProblem()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        char[] num = input[0].ToCharArray();
        int k = Convert.ToInt16(input[1]);
        for (int i = 0; i < num.Length && k > 0; i++)
        {
            if (num[i] != '9')
            {
                num[i] = '9';
                k--;
            }
        }
        Console.Write(num);
    }
}
