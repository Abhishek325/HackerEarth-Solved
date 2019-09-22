using System;
using System.Collections.Generic;
using System.Linq;
class BobTheBuilder
{
    public BobTheBuilder()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        long[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
        Dictionary<long, long> map = new Dictionary<long, long>();
        for (long i = 0; i < arr.Length; i++)
        {
            if (map.ContainsKey(arr[i]))
                map[arr[i]] = map[arr[i]] + 1;
            else
                map.Add(arr[i], 1);
        }
        Console.WriteLine(map.OrderBy(x => x.Key).FirstOrDefault(x => x.Value.Equals(map.Values.Max())).Key);
    }
}
