using System;
class NobitaAndString
{
    NobitaAndString()
    {
        int t = Convert.ToInt16(Console.ReadLine());
        while (t-- > 0)
        {
            string[] words = Console.ReadLine().Split(' ');
            for (int i = 0; i < words.Length / 2; i++)
            {
                string temp = words[words.Length - i - 1];
                words[words.Length - i - 1] = words[i];
                words[i] = temp;
            }
            foreach (string w in words)
            {
                Console.Write(w + " ");
            }
            Console.WriteLine("");
        }
    }
}
