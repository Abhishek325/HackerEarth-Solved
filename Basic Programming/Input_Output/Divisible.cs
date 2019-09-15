using System;

class Divisible
{
    public Divisible()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A = Console.ReadLine().Split(' ');
        int dividingIndex = Convert.ToInt32(n) / 2;

        string firstDigitsTogether = string.Empty;
        string lastDigitsTogether = string.Empty;

        for (int i = 0; i < dividingIndex; i++)
        {
            firstDigitsTogether += A[i][0];
        }

        for (int i = dividingIndex; i < n; i++)
        {
            lastDigitsTogether += A[i][A[i].Length - 1];
        }

        string res = firstDigitsTogether + lastDigitsTogether;
        int sumOfEvenPositions = 0, sumOfOddPositions = 0;
        for (int i = 0; i < res.Length; i++)
        {
            if (i % 2 == 0)
                sumOfEvenPositions += Convert.ToInt16(res[i]);
            else
                sumOfOddPositions += Convert.ToInt16(res[i]);
        }

        int result = sumOfEvenPositions - sumOfOddPositions;
        if (result == 0 || Math.Abs(result) == 11)
            Console.WriteLine("OUI");
        else
            Console.WriteLine("NON");
    }
}

