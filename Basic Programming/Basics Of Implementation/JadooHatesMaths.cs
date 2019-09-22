using System;

class JadooHatesMaths
{
    public  JadooHatesMaths()
    {
        int n = Convert.ToInt16(Console.ReadLine()) + 1;
        while (n % 3 == 0 || n.ToString().Contains("3"))
        {
            n++;
        }
        Console.WriteLine(n);
    }
}
