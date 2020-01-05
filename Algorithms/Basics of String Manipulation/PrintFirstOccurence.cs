using System; 
class PrintFirstOccurence
{
    PrintFirstOccurence()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            foreach (char c in input)
            {
                if (!output.Contains(c.ToString()))
                {
                    output += c.ToString();
                }
            }
            Console.WriteLine(output);
        }
    }
}
