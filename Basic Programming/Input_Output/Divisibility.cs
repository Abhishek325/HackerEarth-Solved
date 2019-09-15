using System;

class Divisibility
{
    public Divisibility()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A = Console.ReadLine().Split(' ');
        if (A[n - 1][A[n - 1].Length - 1].ToString() == "0")
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}

