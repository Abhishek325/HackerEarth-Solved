using System;
class FriendsRelationship
{
    public FriendsRelationship()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = i + 1; j <= (2 * n - i); j++)
                {
                    Console.Write("#");
                }
                for (int j = (2 * n - i + 1); j <= 2 * n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

