using System;
class VowelPhobia
{
    VowelPhobia()
    {
        Int32 t = Convert.ToInt32(Console.ReadLine());
            while(t-- > 0)
            {
                string input = Console.ReadLine();
                int originalLength = input.Length;
                input = input.ToLower().Replace("a","").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
                Console.WriteLine(originalLength - input.Length);
            }
    }
}