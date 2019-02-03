using System;

public class Duration
{
    public string getDuration(int sh, int sm, int eh, int em)
    {
        int hrDiff = eh - sh;
        int minuteDiff = em - sm;
        if (minuteDiff < 0)
        {
            minuteDiff = 60 + minuteDiff;
            hrDiff = hrDiff - 1;
        }
        return hrDiff + " " + minuteDiff;
    }
    public Duration()
    {
        int noOfTasks = Convert.ToInt16(Console.ReadLine());
        string[] output = new string[noOfTasks];
        while (noOfTasks-- > 0)
        {
            string input = Console.ReadLine();
            int sh = Convert.ToInt16(input.Split(' ')[0]);
            int sm = Convert.ToInt16(input.Split(' ')[1]);
            int eh = Convert.ToInt16(input.Split(' ')[2]);
            int em = Convert.ToInt16(input.Split(' ')[3]);

            output[noOfTasks] = getDuration(sh, sm, eh, em);
        }

        for (int i = (output.Length - 1); i >= 0; i--)
        {
            Console.WriteLine(output[i]);
        }
    }
}