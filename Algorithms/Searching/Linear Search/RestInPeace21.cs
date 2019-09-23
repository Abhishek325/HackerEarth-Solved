using System;

class RestInPeace21
{
    public RestInPeace21()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n.ToString().Contains("21") || n % 21 == 0)
            {
                Console.WriteLine("The streak is broken!");
            }
            else
                Console.WriteLine("The streak lives still in our heart!");
        }
    }
}