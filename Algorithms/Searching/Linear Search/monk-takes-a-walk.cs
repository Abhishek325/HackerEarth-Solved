using System;

class monk_takes_a_walk
{
    public monk_takes_a_walk()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            string input = Console.ReadLine();
            string vowels = "aeiouAEIOU";
            int vowelCount = 0;
            foreach (char c in input)
            {
                if (vowels.Contains(c.ToString()))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}

