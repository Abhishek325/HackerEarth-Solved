using System;

class CostOfBalloons
{
    CostOfBalloons()
    {
        int noOftestCases = Convert.ToInt16(Console.ReadLine());
        while (noOftestCases-- > 0)
        {
            string[] costs = Console.ReadLine().Split(' ');
            int cost1 = Convert.ToInt16(costs[0]);
            int cost2 = Convert.ToInt16(costs[1]);
            int lowCost = cost1 > cost2 ? cost2 : cost1;
            int moreCost = lowCost == cost1 ? cost2 : cost1;
            int n = Convert.ToInt16(Console.ReadLine());
            int sumLeft = 0, sumRight = 0;
            while (n-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                sumLeft += Convert.ToInt16(input[0]);
                sumRight += Convert.ToInt16(input[1]);
            }
            if (sumLeft > sumRight)
                Console.WriteLine(sumLeft * lowCost + sumRight * moreCost);
            else
                Console.WriteLine(sumLeft * moreCost + sumRight * lowCost);
        }
    }
}