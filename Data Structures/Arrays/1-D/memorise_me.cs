using System;
using System.Collections.Generic;

namespace HackerEarth.Arrays
{
    class memorise_me
    {
        public memorise_me()
        {
            execute();
        }
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> map = new Dictionary<int, int>();
            string input = Console.ReadLine();
            string[] tempArr = input.Split(' ');
            for (int i = 0; i < n; i++)
            {
                int key = Convert.ToInt32(tempArr[i]);
                if (map.ContainsKey(key))
                {
                    map[key] = map[key] + 1;
                }
                else
                {
                    map[key] = 1;
                }
            }
            int queryCount = Convert.ToInt32(Console.ReadLine());
            int[] output = new int[queryCount];
            for (int i = 0; i < queryCount; i++)
            {
                int queryNum = Convert.ToInt32(Console.ReadLine());
                map.TryGetValue(queryNum, out output[i]);
            }
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == 0)
                    Console.WriteLine("NOT PRESENT");
                else
                    Console.WriteLine(output[i]);
            }
        }
    }
}
