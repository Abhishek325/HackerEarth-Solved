using System;

class CompilerVersion
{
    CompilerVersion()
    {
        string input = string.Empty;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            if (!input.Contains("->"))
                Console.WriteLine(input);
            else
            {
                string output = string.Empty;
                if (input.Contains("//"))
                {
                    int commentStartIndex = input.IndexOf("//");
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i < commentStartIndex && input[i] == '-' && input[i + 1] == '>')
                        {
                            output += '.';
                            i++;
                        }
                        else
                            output += input[i];
                    }
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine(input.Replace("->", "."));
                }
            }
        }
    }
}