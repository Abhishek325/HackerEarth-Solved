using System;
using System.Collections.Generic;

class Anagrams
{
    public Anagrams()
    {
        string input = Console.ReadLine();
        int testCaseCount = Convert.ToInt16(input);
        int[] output = new int[testCaseCount];
        while (testCaseCount-- > 0)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int count = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in str1)
            {
                if (map.ContainsKey(c))
                    map[c] = map[c] + 1;
                else
                    map[c] = 1;
            }
            foreach (char c in str2)
            {
                if (map.ContainsKey(c))
                {
                    if (map[c] == 0)
                        count++;
                    else
                        map[c] = map[c] - 1;
                }
                else
                    count++;
            }
            foreach (int value in map.Values)
            {
                if (value > 0) count += value;
            }
            output[testCaseCount] = count;
        }
        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(output[i]);
        }
    }

    public string sort(string s)
    {
        char[] arr = s.ToCharArray();
        for (int i = 1; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    char temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return new string(arr);
    }
}