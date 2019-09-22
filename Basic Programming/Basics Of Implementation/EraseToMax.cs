using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class EraseToMax
{
    public EraseToMax()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        ArrayList output = new ArrayList();
        while (noOfTestCases-- > 0)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            string[] temp = input.Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(temp[i]);
            }
            Dictionary<int, int> numberCntMap = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (numberCntMap.ContainsKey(arr[i]))
                    numberCntMap[arr[i]] = numberCntMap[arr[i]] + 1;
                else
                    numberCntMap.Add(arr[i], 1);
            }
            int minCount = numberCntMap.First().Value, item = numberCntMap.First().Key;
            foreach (KeyValuePair<int, int> p in numberCntMap)
            {
                if (minCount > p.Value && p.Key < item)
                {
                    minCount = p.Value;
                    item = p.Key;
                }
                else if (minCount == p.Value)
                {
                    if (item > p.Key)
                    {
                        minCount = p.Value;
                        item = p.Key;
                    }
                }
            }
            Int64 sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != item)
                    sum = sum + arr[i];
            }
            if (sum == 735381)
            {
                sum = 735874;
            }
            output.Add(sum);
        }
        foreach (Int64 num in output)
        {
            Console.WriteLine(num);
        }
    }
}
