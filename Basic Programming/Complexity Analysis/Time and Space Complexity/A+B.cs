using System;
using System.Numerics;
class A_B
{
    public A_B()
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (input == null)
            {
                break;
            }
            string[] inp = input.Split(' ');
            BigInteger num1 = BigInteger.Parse(inp[0]);
            BigInteger num2 = BigInteger.Parse(inp[1]);
            Console.WriteLine(num1 + num2);
        }
    }
}
