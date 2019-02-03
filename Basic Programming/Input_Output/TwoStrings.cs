using System;
using System.Linq;
class TwoStrings
{
    public TwoStrings()
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int s = 0; s < t; s++)
        {
            string[] ab = Console.ReadLine().Split(' ').ToArray();
            string a = ab[0];
            string b = ab[1];
            int[] ca = new int[26];
            int[] cb = new int[26];
            for (int i = 0; i < a.Length; i++)
            {
                ca[a[i] - 'a']++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                cb[b[i] - 'a']++;
            }
            bool equal = true;
            for (int i = 0; i < 26; i++)
            {
                if (ca[i] != cb[i])
                {
                    equal = false;
                    break;
                }
            }
            if (equal)
            {
                Console.WriteLine("YES");
            }
            else {
                Console.WriteLine("NO");
            }
        }
    }
}