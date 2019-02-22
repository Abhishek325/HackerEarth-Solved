using System;
using System.Linq;

class FindProduct
{
    public FindProduct()
    {
        int n = Convert.ToInt16(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        long answer = 1;
        for (int i = 0; i < n; i++)
        {
            answer = answer * arr[i] % (1000000000 + 7);
        }
        Console.Write(answer);
    }
}