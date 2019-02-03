using System;

class CountDivisors
{
    public int getDivisorCount(int l, int r, int k)
    {
        int divisorCount = 0;
        for (int i = l; i <= r; i++)
        {
            if (i % k == 0)
            {
                divisorCount++;
            }
        }
        return divisorCount;
    }
    public CountDivisors()
    {
        string ip = Console.ReadLine();
        string[] input = ip.Split(' ');
        int l = Convert.ToInt16(input[0]);
        int r = Convert.ToInt16(input[1]);
        int k = Convert.ToInt16(input[2]);
        Console.WriteLine(getDivisorCount(l, r, k));
    }
}