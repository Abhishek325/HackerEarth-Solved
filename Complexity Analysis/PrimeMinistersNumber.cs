using System;
public class PrimeMinistersNumber
{
    public static bool isDigitsSumPrime(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum = sum + digit;
            num = num / 10;
        }
        return isPrimeNumber(sum);
    }
    public static bool isPrimeNumber(int i)
    {
        Boolean flag = true;
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
                flag = false;
        }
        if (flag == true)
            return true;
        else
            return false;


    }
    public PrimeMinistersNumber()
    {
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input.Split(' ')[0]);
        int b = Convert.ToInt32(input.Split(' ')[1]);
        for (int i = a; i <= b; i++)
        {
            if (isPrimeNumber(i) && isDigitsSumPrime(i))
                Console.Write(i + " ");
        }
    }
}