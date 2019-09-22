using System;
class AdditionAintSimple
{
    public AdditionAintSimple()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            string input = Console.ReadLine();
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            string reverse = new string(temp);
            char[] newArr = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int value = (input[i] - 96) + (reverse[i] - 96);
                while (value > 26)
                {
                    value = value - 26;
                }
                newArr[i] = (char)(value + 96);
            }
            Console.WriteLine(new string(newArr));
        }
    }
}