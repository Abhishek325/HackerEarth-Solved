using System;
class UpUp
{
    public UpUp()
    {
        string[] str = Console.ReadLine().Split(' ');
        foreach (string item in str)
        {
            if (item.Length > 0) Console.Write(item[0].ToString().ToUpper() + item?.Substring(1, item.Length - 1) + " ");
            else Console.Write(" ");
        }
    }
}
