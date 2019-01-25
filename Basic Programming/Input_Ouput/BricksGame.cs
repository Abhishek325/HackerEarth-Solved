using System;

class BricksGame
{
    public BricksGame()
    {
        string input = Console.ReadLine();
        int totalBricksCount = Convert.ToInt16(input);
        int motu = 0, patlu = 0, count = 0, flag = 0;
        while (totalBricksCount > 0)
        {
            count++;
            patlu = patlu + 1;
            totalBricksCount = totalBricksCount - patlu;
            if (totalBricksCount < 0)
            {
                flag = 1;
                break;
            }
            motu = patlu * 2;
            totalBricksCount = totalBricksCount - motu;
            if (totalBricksCount < 0)
            {
                flag = 2;
                break;
            }
        }
        Console.WriteLine((flag == 2) ? "Motu" : "Patlu");
    }
}