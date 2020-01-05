using System;
class MonkTeachedPalindrome
{
    MonkTeachedPalindrome()
    {
        Int32 t = Convert.ToInt32(Console.ReadLine());
        while (t-- > 0)
        {
            string input = Console.ReadLine();
            bool isPalindrome = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    isPalindrome = false;
                    Console.WriteLine("NO");
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("YES " + (((input.Length % 2) == 0) ? "EVEN" : "ODD"));
            }
        }
    }
}