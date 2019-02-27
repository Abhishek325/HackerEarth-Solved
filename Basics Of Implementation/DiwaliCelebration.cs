using System;
class DiwaliCelebration
{
    public DiwaliCelebration()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            string input = Console.ReadLine();
            string[] temp = input.Split(' ');
            int a = Convert.ToInt16(temp[0]);
            int k = Convert.ToInt16(temp[1]);
            int n = Convert.ToInt16(temp[2]);

            Console.WriteLine(a + (n - 1) * k);
        }
    }
}
