using System;
using System.Text;
public class MagicalWord
{
    private int findNearestPrimeBackward(int num, ref bool changed)
    {
        if (num == 65 || num == 97)
            return num;
        changed = true;
        while (!isPrime(num))
        {
            num--;
        }
        return num;
    }
    private int findNearestPrimeForward(int num, ref bool changed)
    {
        if (num == 90 || num == 122)
            return num;
        changed = true;
        while (!isPrime(num))
        {
            num++;
        }
        return num;
    }
    private bool isLetter(int ascii)
    {
        if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122))
            return true;
        return false;
    }
    private int ConverToLetter(int num)
    {
        bool dummy = false;
        return findNearestPrimeForward(65, ref dummy);
    }
    public string convertToDhananjaysMagicalWord(string text)
    {
        StringBuilder magicalWord = new StringBuilder();
        foreach (char c in text)
        {
            int ascii = c;
            bool b_changed = false, f_changed = false;
            if (!isPrime(ascii) || !isLetter(ascii))
            {
                int previousPrimeNumber = findNearestPrimeBackward(ascii, ref b_changed);
                if (b_changed && !isLetter(previousPrimeNumber))
                {
                    previousPrimeNumber = ConverToLetter(previousPrimeNumber);
                }
                int forwardPrimeNumber = findNearestPrimeForward(ascii, ref f_changed);
                if (f_changed && !isLetter(forwardPrimeNumber))
                {
                    forwardPrimeNumber = ConverToLetter(forwardPrimeNumber);
                }
                if (b_changed && f_changed)
                    magicalWord.Append((Math.Abs(previousPrimeNumber - ascii) < Math.Abs(forwardPrimeNumber - ascii)) ? (char)previousPrimeNumber : (Math.Abs(previousPrimeNumber - ascii) == Math.Abs(forwardPrimeNumber - ascii)) ? (char)previousPrimeNumber : (char)forwardPrimeNumber);
                else magicalWord.Append(b_changed ? (char)previousPrimeNumber : (char)forwardPrimeNumber);
            }
            else
                magicalWord.Append(c.ToString());
        }
        return magicalWord.ToString();
    }
    private bool isPrime(int num)
    {
        for (int i = 2; i <= (num / 2); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
    public MagicalWord()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        string[] output = new string[noOfTestCases];
        while (noOfTestCases-- > 0)
        {
            int lengthOfSString = Convert.ToInt16(Console.ReadLine());
            string inputString = Console.ReadLine();
            output[noOfTestCases] = convertToDhananjaysMagicalWord(inputString);
        }
        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(output[i]);
        }
    }
}