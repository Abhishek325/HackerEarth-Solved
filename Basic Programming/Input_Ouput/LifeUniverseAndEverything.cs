using System;
public class LifeUniverseAndEverything
{
    public LifeUniverseAndEverything()
    {
        string x = "", temp = "";
        while ((temp = Console.ReadLine()) != "42")
        {
            x = x + "\n" + temp;
        }
        Console.WriteLine(x);
    }
}