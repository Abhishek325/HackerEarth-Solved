using System;
class AraniaExumiaBlast
{
    public AraniaExumiaBlast()
    {
        string str = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                count++;
                i++;
            }
        }
        Console.WriteLine(count);
    }
}
