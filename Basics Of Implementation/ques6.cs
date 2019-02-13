using System;

class ques6
{
    public ques6()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int tot = n;
            for (int i = 1; ; i++)
            {
                if (tot <= 0)
                {
                    break;
                }
                if (i % 2 != 0)
                {
                    int num = 2 * n - 1;
                    int temp = Convert.ToInt16(Math.Ceiling((double)(num - i) / 2));
                    while (temp-- > 0)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    num = 2 * n - 1;
                    temp = Convert.ToInt16(Math.Ceiling((double)(num - i) / 2));
                    while (temp-- > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("");
                    tot--;
                }
            }
        }
    }
}