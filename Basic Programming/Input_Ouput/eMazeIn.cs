using System;
class eMazeIn
{
    public string getPositionCoordinates(string commandString)
    {
        int x = 0, y = 0;
        for (int i = 0; i < commandString.Length; i++)
        {
            switch (commandString[i])
            {
                case 'L':
                    x = x - 1;
                    break;
                case 'R':
                    x = x + 1;
                    break;
                case 'D':
                    y = y - 1;
                    break;
                case 'U':
                    y = y + 1;
                    break;
            }
        }
        return x + " " + y;
    }
    public eMazeIn()
    {
        Console.WriteLine(getPositionCoordinates(Console.ReadLine()));
    }
}