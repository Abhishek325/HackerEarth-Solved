using System;
using System.Collections.Generic;
using System.Linq;
class MollyAndFlame
{
    public MollyAndFlame()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            string[] input = Console.ReadLine().Split(' ');
            string str1 = input[0];
            string str2 = input[1];
            Dictionary<int, char> flames = new Dictionary<int, char>()
                {
                    {1,'F' },
                    {2,'L' },
                    {3,'A' },
                    {4,'M' },
                    {5,'E' }
                };
            int count = 0;
            foreach (var c1 in str1)
            {
                if (!str2.Contains(c1)) count++;
            }
            foreach (var c2 in str2)
            {
                if (!str1.Contains(c2)) count++;
            }
            int i = count % 5 == 0 ? 5 : count % 5;
            char res = flames[i];
            int index = "FLAME".IndexOf(res);
            if (index == -1)
            {
                Console.WriteLine("FLAME");
            }
            else
            {
                char[] str = { 'F', 'L', 'A', 'M', 'E' };
                str[index] = 'L';
                str[1] = flames[i];
                Console.WriteLine(new string(str));
            }
        }
    }
}
