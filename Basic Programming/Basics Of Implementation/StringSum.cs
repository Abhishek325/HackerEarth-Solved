using System;
public class StrinSum
{
    public StrinSum()
    {
        string input = Console.ReadLine();
        int sum = 0;
        foreach (char c in input)
        {
            sum = sum + (int)c - 96;
        }
        Console.Write("" + sum);
    }
}
