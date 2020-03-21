using System;
using System.Collections.Generic;
using System.Linq;
class RajanAndOddFrequencyNumber
{
    public RajanAndOddFrequencyNumber()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (var item in arr)
        {
            if (map.ContainsKey(item))
                map[item] += 1;
            else map.Add(item, 1);
        }
        Console.WriteLine(map.First(x => x.Value % 2 != 0).Key);
    }
}
