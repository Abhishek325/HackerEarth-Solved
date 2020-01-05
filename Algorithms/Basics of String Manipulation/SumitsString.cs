using System;
class SumitsString
{
    SumitsString()
    {
        Int32 t = Convert.ToInt32(Console.ReadLine());
        while (t-- > 0)
        {
            string input = Console.ReadLine();
            bool isValid = true;
            for (int i = 0; i < input.Length - 1; i++)
            {
                int n1 = input[i];
                int n2 = input[i + 1];
                int diff = Math.Abs(n1 - n2);
                if ((diff > 1 || diff == 0) && diff != 25)
                {
                    isValid = false;
                    Console.WriteLine("NO");
                    break;
                }
            }
            if (isValid)
                Console.WriteLine("YES");
        }
    }
}