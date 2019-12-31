using System;

class Movement
{
    public Movement()
    {
        Int32 n = Convert.ToInt32(Console.ReadLine());
        int stepsCount = 0;
        while (n > 0)
        {
            if (n % 5 == 0)
                n = n - 5;
            else
                n = n - (n % 5);
            stepsCount++;
        }
        Console.WriteLine(stepsCount);
    }
}
