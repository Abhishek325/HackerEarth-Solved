using System;
using System.Collections.Generic;

public class SeatingArrangement
{
    private class Seat
    {
        public int Key;
        public int Value;
        public Seat(int a, int b)
        {
            Key = a;
            Value = b;
        }
    }
    public int findNextDivisibleNumberBy6(int seatNo)
    {
        int nextDivisible = 0;
        nextDivisible = seatNo;
        while (nextDivisible % 6 != 0)
        {
            nextDivisible++;
        }
        return nextDivisible;
    }
    public string getSeatPositions(int seatNo)
    {
        int j = 0, oppositeSeat = 0;
        string seatPosition = string.Empty;
        List<Seat> seatOppositeSeatPair = new List<Seat>();

        for (int i = 1; i <= findNextDivisibleNumberBy6(seatNo); i = i + 6)
        {
            new Seat(1, 2);
            j++;
            if (j % 2 == 0)
                seatOppositeSeatPair.Add(new Seat(i + 5, i));
            else
                seatOppositeSeatPair.Add(new Seat(i, i + 5));
        }
        j = 1;
        foreach (Seat x in seatOppositeSeatPair)
        {
            if ((x.Key <= seatNo && x.Value >= seatNo) || (x.Key >= seatNo && x.Value <= seatNo))
            {
                int offsetFromSource = Math.Abs((j % 2 == 0) ? (seatNo - x.Key) : ((seatNo - x.Value)));
                switch (seatNo % 3)
                {
                    case 0:
                        if (seatNo == ((j % 2 == 0) ? x.Key : x.Value))
                            seatPosition = "WS";
                        else
                            seatPosition = "AS";
                        break;
                    case 1:
                        if (seatNo == ((j % 2 == 0) ? x.Value : x.Key))
                            seatPosition = "WS";
                        else
                            seatPosition = "AS";
                        break;
                    case 2:
                        seatPosition = "MS";
                        break;
                }
                int temp = (j % 2 != 0) ? (12 - (12 - (offsetFromSource * 2) - 1)) : ((12 - (offsetFromSource * 2) - 1));
                oppositeSeat = (j % 2 == 0) ? (seatNo - temp) : (seatNo + temp);
                break;
            }
            j++;
        }
        seatOppositeSeatPair = null;
        return (oppositeSeat.ToString() + " " + seatPosition);
    }
    public SeatingArrangement()
    {
        int noTestCases = Convert.ToInt32(Console.ReadLine());
        string[] output = new string[noTestCases];
        while (noTestCases-- > 0)
        {
            int seatNo = Convert.ToInt16(Console.ReadLine());
            output[noTestCases] = getSeatPositions(seatNo);
        }
        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(output[i]);
        }
    }
}