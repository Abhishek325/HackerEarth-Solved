using System;
using System.Collections.Generic;
using System.Linq;
class DeterminingNumbers
{
    public DeterminingNumbers()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (var item in arr)
        {
            if (map.ContainsKey(item)) map[item] += 1;
            else map.Add(item,1);
        }
        // multiple select from dictionary
        var res = map.Where(x => x.Value == 1).OrderBy(x => x.Key).Select(x => x.Key).ToList();
        foreach (var item in res)
        {
            Console.Write(item+" ");
        }
    }
}
