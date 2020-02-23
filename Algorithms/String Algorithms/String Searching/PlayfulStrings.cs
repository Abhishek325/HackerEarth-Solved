using System;
class PlayfulStrings
{
    PlayfulStrings()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string str = Console.ReadLine();
            bool isP = true;
            for (int i = 0; i < str.Length - 1; i++)
            {
                int diff = Math.Abs(str[i] - str[i + 1]);
                if (diff != 1 && diff != 25) { isP = false; break; }
            }
            Console.WriteLine(isP ? "YES" : "NO");
        }
    }
}