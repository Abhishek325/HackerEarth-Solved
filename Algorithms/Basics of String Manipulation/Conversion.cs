using System;
class Conversion
{
    Conversion()
    {
        Int32 t = Convert.ToInt32(Console.ReadLine());
        while (t-- > 0)
        {
            string input = Console.ReadLine().ToLower();
            string output = string.Empty;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    output += "$";
                    continue;
                }
                int convertedNumber = c - 96;
                output += convertedNumber;
            }
            Console.WriteLine(output);
        }
    }
}