using System;
class ToggleString
{
    public string flipCase(string str)
    {
        char[] newStr = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 65 && str[i] <= 91)
            {
                newStr[i] = (char)(str[i] + 32);
            }
            else
                newStr[i] = (char)(str[i] - 32);
        }
        return new string(newStr);
    }
    public ToggleString()
    {
        Console.WriteLine(flipCase(Console.ReadLine()));
    }
}