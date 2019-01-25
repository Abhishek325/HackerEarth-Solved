using System;

class Factorial
{
    public int factorial(int n)
    {
        if (n == 1 || n == 0) return 1;
        return n * factorial(n - 1);
    }
    public Factorial()
    {
        Console.WriteLine(Convert.ToInt16(Console.ReadLine()));
    }
}