using System;
class StringGame
{
    public StringGame()
    {
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        while (noOfTestCases-- > 0)
        {
            string input = Console.ReadLine();
            int playerChanceIndicator = 0;
            while (input.Length > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    input = input.Replace(input[i].ToString(), "");
                    playerChanceIndicator++;
                }
            }
            if (playerChanceIndicator % 2 == 0)
                Console.WriteLine("Player2");
            else
                Console.WriteLine("Player1");
        }
    }
}
