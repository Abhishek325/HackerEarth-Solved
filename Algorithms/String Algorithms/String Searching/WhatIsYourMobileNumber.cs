using System;

class WhatIsYourMobileNumber
{
    WhatIsYourMobileNumber()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string str = Console.ReadLine();
            bool isValid = true;
            if (str.Length != 10 || str[0] == '0')
            {
                Console.WriteLine("NO");
                continue;

            }
            foreach (char c in str)
            {
                if (c < 48 || c > 57)
                {
                    isValid = false;
                    break;
                }
            }
            Console.WriteLine(!isValid?"NO":"YES");
        }
    }
}