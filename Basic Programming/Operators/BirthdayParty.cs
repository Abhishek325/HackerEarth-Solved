using System;
using System.Linq;
class BirthdayParty
{
    public BirthdayParty()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = input[0];
            int m = input[1];
            Console.WriteLine(m % n == 0 ? "Yes" : "No");
        }
    }
}
