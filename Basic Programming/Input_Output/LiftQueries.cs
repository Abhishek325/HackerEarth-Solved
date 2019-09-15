using System;

class LiftQueries
{
    public LiftQueries()
    {
        int noOfTestCases = Convert.ToInt32(Console.ReadLine());
        int A = 0;
        int B = 7;
        while (noOfTestCases-- > 0)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int diff1 = Math.Abs(n - A);
            int diff2 = Math.Abs(n - B);
            if (diff1 <= diff2)
            {
                Console.WriteLine("A");
                A = n;
            }
            else
            {
                Console.WriteLine("B");
                B = n;
            }
        }
    }
}
