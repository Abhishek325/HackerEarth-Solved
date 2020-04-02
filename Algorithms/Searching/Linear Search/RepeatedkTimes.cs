using System;
using System.Collections.Generic;
using System.Linq;
class RepeatedkTimes
{
    public RepeatedkTimes()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        int k = Convert.ToInt32(Console.ReadLine());
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (freqMap.ContainsKey(num))
                freqMap[num] += 1;
            else freqMap.Add(num, 1);
        }
        Console.WriteLine(freqMap.OrderBy(x => x.Key).FirstOrDefault(x => x.Value.Equals(k)).Key);
    }
}
