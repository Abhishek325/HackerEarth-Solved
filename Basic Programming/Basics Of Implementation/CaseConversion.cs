using System;
using System.Text;

class CaseConversion
{
    CaseConversion()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string camelCaseString = Console.ReadLine();
            StringBuilder snakeCaseString = new StringBuilder();
            for (int i = 0; i < camelCaseString.Length; i++)
            {
                char c = camelCaseString[i];
                if (c >= 65 && c <= 91)
                {
                    if (i > 0)
                        snakeCaseString.Append("_");
                    snakeCaseString.Append((char)(c + 32));
                }
                else
                    snakeCaseString.Append(c.ToString());
            }
            Console.WriteLine(snakeCaseString);
        }
    }
}