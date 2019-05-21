using System;

class TheDice
{
    public TheDice()
    {
        string sequence = Console.ReadLine();
        int count = 0;
        if (sequence[sequence.Length - 1].ToString().Equals("6"))
        {
            Console.WriteLine(-1);
            return;
        }
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i].ToString() != "6")
                count++;
        }
        Console.WriteLine(count);
    }
}

