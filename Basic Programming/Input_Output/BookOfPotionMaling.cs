using System;
public class BookOfPotionMaling
{
    public BookOfPotionMaling()
    {
        string isbn = Console.ReadLine();
        if (isbn.Length != 10)
        {
            Console.WriteLine("Illegal ISBN");
            return;
        }
        int sum = 0;
        for (int i = 0; i < isbn.Length; i++)
        {
            sum = sum + (i + 1) * isbn[i];
        }
        Console.WriteLine((sum % 11 == 0) ? "Legal ISBN" : "Illegal ISBN");
    }
}