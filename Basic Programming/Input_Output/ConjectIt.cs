using System;
using System.Numerics;
using System.Collections.Generic;
class ConjectIt
{
    public ConjectIt()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Dictionary<BigInteger, BigInteger> map = new Dictionary<BigInteger, BigInteger>();
            bool flag = true;
            BigInteger newNum = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                    newNum = n / 2;
                else
                    newNum = 3 * n + 1;
                if (map.ContainsKey(n))
                {
                    flag = false;
                    break;
                }
                map.Add(n, newNum);
                n = newNum;
            }
            if (flag)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}

