using System;
using System.Linq;

class Back_to_School
{
    public Back_to_School()
    {
        Int16[] numbers = Console.ReadLine().Split(' ').Select(x => Convert.ToInt16(x)).ToArray();
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }
        Console.WriteLine(max);
    }
}
