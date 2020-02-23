using System;
class CanYouCount
{
    CanYouCount()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string vowels = "aeiou";
        while (n-- > 0)
        {
            string str = Console.ReadLine();
            int i = 0, count = 0;
            Int64 total = 1;
            string traversedVowels = string.Empty;
            while (i < str.Length)
            {
                if (vowels.Contains(str[i].ToString()) && !traversedVowels.Contains(str[i].ToString()))
                {
                    traversedVowels += str[i];
                    count++;
                }
                else if (str[i] == '_')
                {
                    total = total * (count == 0 ? 1 : count);
                }
                i++;
            }
            Console.WriteLine(total);
        }
    }
}