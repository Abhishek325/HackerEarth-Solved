using System;
using System.Collections.Generic;
using System.Linq;
class TheBestInternetBrowser
{
    public TheBestInternetBrowser()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            string str = Console.ReadLine();
            int jhoolBrowserCharCount = 0;
            foreach (var c in str.Replace("www.", "").Replace(".com", ""))
            {
                if (!"aeiou".Contains(c))
                {
                    jhoolBrowserCharCount++;
                }
            }
            Console.WriteLine((jhoolBrowserCharCount + 4) + "/" + str.Length);
        }
    }
}
