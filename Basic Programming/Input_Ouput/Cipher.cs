using System;
public class Cipher
{
    public bool isAlphabet(char c)
    {
        if ((c >= 97 && c <= 122) || (c >= 65 && c <= 90))
            return true;
        return false;
    }
    public bool matchCase(char a, char b)
    {
        if (((a >= 97 && a <= 122) && (b >= 97 && b <= 122)) || ((a >= 65 && a <= 90) && (b >= 65 && b <= 90)))
            return true;
        return false;
    }
    public string encryptChar(char c, int key)
    {
        //Numbers
        if (c >= 48 && c <= 57)
            return ((Convert.ToInt16(c - '0') + key) % 10).ToString();

        //Alphabets
        if (isAlphabet(c))
        {
            char temp = (char)(c + key);
            if (temp < 65 || (temp > 91 && temp < 97) || (temp > 122) || !matchCase(c, temp))
            {
                while (true)
                {
                    temp = ((char)(temp - 26));
                    if (isAlphabet(temp) && matchCase(c, temp))
                        break;
                }
            }
            return temp.ToString();

        }
        return c.ToString();
    }
    public Cipher()
    {
        string input = Console.ReadLine();
        int key = Convert.ToInt16(Console.ReadLine());
        string output = String.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            output = output + new Cipher().encryptChar(input[i], key);
        }
        Console.WriteLine(output);
    }
}