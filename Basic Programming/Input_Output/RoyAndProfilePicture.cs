using System;
public class RoyAndProfilePicture
{
    public RoyAndProfilePicture()
    {
        int L = Convert.ToInt16(Console.ReadLine());
        int noOfTestCases = Convert.ToInt16(Console.ReadLine());
        string[] output = new string[noOfTestCases];
        while (noOfTestCases-- > 0)
        {
            string input = Console.ReadLine();
            int W = Convert.ToInt16(input.Split(' ')[0]);
            int H = Convert.ToInt16(input.Split(' ')[1]);
            output[noOfTestCases] = (W < L || H < L) ? "UPLOAD ANOTHER" : (!(W < L) && (W == H) ? "ACCEPTED" : "CROP IT");
        }
        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(output[i]);
        }
    }
}