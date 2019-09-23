using System;
using System.Linq;
using System.Numerics;
class MinMax8
{
    public MinMax8()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger[] a = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
        BigInteger totSum = 0, min = a[0], max = a[n - 1];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min)
                min = a[i];
            if (a[i] > max)
                max = a[i];
            totSum += a[i];
        }
        Console.WriteLine((totSum - max) + " " + (totSum - min));
    }
}

