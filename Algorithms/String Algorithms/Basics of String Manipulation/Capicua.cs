using System;
class Capicua
{
    Capicua()
    {
        Int32 t = Convert.ToInt32(Console.ReadLine());
        while (t-- > 0)
        {
            bool isPalindrome = true;
            string number = Console.ReadLine();
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    isPalindrome = false;
                    Console.WriteLine("NO");
                    break;
                }
            }
            if (isPalindrome)
                Console.WriteLine("YES");
        }
    }
}