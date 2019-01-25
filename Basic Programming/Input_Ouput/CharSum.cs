using System;
public class CharSum
{
    public CharSum()
    {
        string input = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum = sum + input[i] - 96;
        }
        Console.WriteLine(sum);
    }
}