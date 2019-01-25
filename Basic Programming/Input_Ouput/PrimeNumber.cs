using System;
class PrimeNumber
{
    private bool isPrimeNumber(int num)
    {
        if (num == 1)
        {
            return false;
        }
        for (int i = 2; i <= (num / 2); ++i)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public string generatePrimeNumberSequence(int limit)
    {
        if (limit < 2)
            return "0";
        string sequence = string.Empty;
        for (int i = 2; i <= limit; i++)
        {
            if (this.isPrimeNumber(i))
            {
                sequence = sequence + i.ToString() + " ";
            }
        }
        return sequence;
    }

    public PrimeNumber()
    {
        string input = Console.ReadLine();
        int num = Convert.ToInt16(input);
        Console.WriteLine(generatePrimeNumberSequence(num));
    }
}


