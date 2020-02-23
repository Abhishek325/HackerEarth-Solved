using System;
using System.Linq;

namespace HackerEarth.Algorithms.Searching.Linear_Search
{
    class MaximumSum
    {
        public MaximumSum()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Int64 sum = 0, totalNum = 0, max = -int.MaxValue;
            Int64[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
            foreach (var item in arr)
            {
                if (item >= 0)
                {
                    sum += item;
                    totalNum++;
                }
                else
                {
                    if (max < item)
                        max = item;
                }
            }
            if (totalNum > 0)
                Console.WriteLine("{0} {1}", sum, totalNum);
            else
                Console.WriteLine("{0} {1}", max, 1);
        }
    }
}