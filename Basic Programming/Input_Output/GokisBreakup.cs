using System;
public class GokisBreakup
{
    public GokisBreakup()
    {
        int noOfPeople = Convert.ToInt16(Console.ReadLine());
        int x = Convert.ToInt16(Console.ReadLine());
        string[] output = new string[noOfPeople];
        for (int i = 0; i < noOfPeople; i++)
        {
            int y = Convert.ToInt16(Console.ReadLine());
            output[i] = (y >= x) ? "YES" : "NO";
        }
        for (int i = 0; i < output.Length; i++)
        {
            Console.WriteLine(output[i]);
        }
    }
}