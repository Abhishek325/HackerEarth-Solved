using System;
using System.Linq;

class TheSavior
{
    public TheSavior()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            Int16[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt16(x)).ToArray();
            int evenCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) % 2 == 0 && arr[i] != arr[j])
                    {
                        evenCount++;
                    }
                }
            }
            Console.WriteLine(evenCount);
        }
    }
}


