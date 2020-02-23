using System;
class MannasFirstName
{
    public MannasFirstName()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string str = Console.ReadLine();
            string suvojitStr = str.Replace("SUVOJIT", "");
            int l_suvojit = (str.Length - suvojitStr.Length) / 7;
            int l_suvo = (suvojitStr.Length - suvojitStr.Replace("SUVO", "").Length) / 4;
            Console.WriteLine("SUVO = {0}, SUVOJIT = {1}", l_suvo, l_suvojit);
        }
    }
}
