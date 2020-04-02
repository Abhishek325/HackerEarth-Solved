using System;
class JumbleLetter
{
    public JumbleLetter()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string str = Console.ReadLine();
            string res = string.Empty;
            foreach (var item in str)
            {
                if (!"aeiouy".Contains(item.ToString().ToLower()))
                    res += ("." + item.ToString().ToLower());
            }
            Console.WriteLine(res);
        }
    }
}
