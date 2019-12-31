using System;

class teddy_and_tweety
{
    public teddy_and_tweety()
    {
        int n = Convert.ToInt16(Console.ReadLine());
        if (n % 3 == 0)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
