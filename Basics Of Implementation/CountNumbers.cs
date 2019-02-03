using System;
using System.Text.RegularExpressions;
class CountNumbers
{
    public CountNumbers()
    { 
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        int[] output = new int[noOfTestCases];
        while (noOfTestCases-- > 0)
        {
            int stringLength = Convert.ToInt16(Console.ReadLine());
            string str = Console.ReadLine();
            str = Regex.Replace(str, @"[a-zA-Z]", "|");
            string[] temp = str.Split('|');
            int count = 0;
            foreach (string s in temp)
            {
                if (s.Length > 0)
                    count++;
            }
            output[noOfTestCases] = count;
        }
        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(output[i]);
        }
    }
}