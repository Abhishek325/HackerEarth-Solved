using System;

class Zoos
{
    Zoos()
    {
        string str = Console.ReadLine();
        string temp = str;
        int countofZ = str.Length - temp.Replace('z', ' ').TrimStart().Length;
        int countOfO = str.Length - temp.Replace('o', ' ').TrimEnd().Length;
        Console.WriteLine(countOfO == (2 * countofZ) ? "Yes" : "No");
    }
}
