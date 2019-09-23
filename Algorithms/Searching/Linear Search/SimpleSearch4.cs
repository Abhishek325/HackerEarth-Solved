using System;
using System.Linq;
using System.Numerics;
class SimpleSearch4
{
    public SimpleSearch4()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger[] a = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (a[i] == k)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}
