using System;
class TerribleChandu
{
    TerribleChandu()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string str = Console.ReadLine();
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(new string(c));
        }
    }
}