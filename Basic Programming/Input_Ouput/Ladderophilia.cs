using System;
public class Ladderophilia
{
    public void printRail()
    {
        Console.WriteLine("*   *");
        Console.WriteLine("*   *");
        Console.WriteLine("*****");
    }
    public Ladderophilia()
    {
        int n = Convert.ToInt16(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            printRail();
        }
        Console.WriteLine("*   *");
        Console.WriteLine("*   *");
    }
}