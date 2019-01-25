using System;
public class AliHelpingInnocentPeople
{
    public AliHelpingInnocentPeople()
    {
        string vowels = "AEIOUY", flag = "valid";
        string tag = Console.ReadLine();
        for (int i = 0; i < tag.Length - 1; i++)
        {
            if (Char.IsDigit(tag[i]))
            {
                if (Char.IsDigit(tag[i + 1]))
                {
                    int sum = tag[i] + tag[i + 1];
                    if (sum % 2 != 0)
                    {
                        flag = "invalid";
                        break;
                    }
                }
            }
            else if (Char.IsLetter(tag[i]))
            {
                if (vowels.Contains("" + tag[i]))
                {
                    flag = "invalid";
                    break;
                }
            }
        }
        Console.WriteLine(flag);
    }
}