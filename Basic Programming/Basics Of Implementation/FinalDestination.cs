using System;

class FinalDestination
{
    FinalDestination()
    {
        string command = Console.ReadLine();
        int x = 0, y = 0;
        foreach (char c in command)
        {
            switch (c)
            {
                case 'L': x -= 1; break;
                case 'R': x += 1; break;
                case 'D': y -= 1; break;
                case 'U': y += 1; break;
            }
        }
        Console.Write(x + " " + y);
    }
}
