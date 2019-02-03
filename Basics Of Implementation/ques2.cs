using System;
using System.Linq;

class ques2
{
    public ques2()
    {
        var input = Console.ReadLine().Split(' ').Select(num => Convert.ToInt16(num)).ToArray();
        int n = input[0];
        int x = input[1];
        int y = input[2];
        int[] arr = Console.ReadLine().Split(' ').Select(num => Convert.ToInt32(num)).ToArray();
        for (int i = 0; i < n; i++)
        {
            if (!(arr[i] >= x && arr[i] <= y))
            {
                Console.WriteLine("NO");
                return;
            }
        }
        Console.WriteLine("YES");
    }
}