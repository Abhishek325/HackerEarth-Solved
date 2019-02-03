using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.Basics_Of_Implementation
{
    class CompressTheString
    {
        public CompressTheString()
        {
            int noOfTestCases = Convert.ToInt16(Console.ReadLine());
            while (noOfTestCases-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();
                string firstLetter = input[0].ToString().ToUpper();
                input = input.Substring(1);
                StringBuilder output = new StringBuilder();
                int count = 0;
                char prevVowel = '$';
                foreach (char c in input)
                {
                    if (isConsonant(c))
                    {
                        if (prevVowel != '$')
                        {
                            output.Append(prevVowel);
                            prevVowel = '$';
                        }
                        count++;
                    }
                    else
                    {
                        if (prevVowel != c && prevVowel != '$')
                        {
                            output.Append(prevVowel);
                        }
                        prevVowel = c;
                        if (count != 0)
                        {
                            output.Append(count);
                            count = 0;
                        }
                    }
                }
                if (prevVowel != '$')
                {
                    output.Append(prevVowel);
                }
                else if (count > 0)
                {
                    output.Append(count);
                }
                Console.WriteLine(firstLetter + output);
            }
        }
        private bool isConsonant(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                return false;
            return true;
        }
    }
}
