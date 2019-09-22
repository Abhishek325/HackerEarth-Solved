using System;
using System.Linq;
using System.Text;
class HawkeyeAndFloodfill
{
    public HawkeyeAndFloodfill()
    {
        int n = Convert.ToInt16(Console.ReadLine());
        Int64[] temp = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
        Int64 i = temp[0];
        Int64 j = temp[1];
        Int64 p = temp[2];
        StringBuilder output = new StringBuilder();
        for (int row = 0; row < n; row++)
        {
            output.Append("\n");
            for (int col = 0; col < n; col++)
            {
                Int64 rowDiff = Math.Abs(row - i);
                Int64 colDiff = Math.Abs(col - j);
                Int64 diff = p - Math.Max(rowDiff, colDiff);
                //Dont even think of printing inside a loop. It created a huge overhead in runtime!!!
                output.Append(((diff < 0) ? 0 : diff) + " ");
            }
        }
        Console.WriteLine(output);
    }
}
