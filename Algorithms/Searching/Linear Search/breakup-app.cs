using System;
using System.Collections.Generic;
using System.Linq;
class breakup_app
{
    public breakup_app()
    {
        int n = Convert.ToInt16(Console.ReadLine());
        Dictionary<int, int> chatNumMap = new Dictionary<int, int>();
        while (n-- > 0)
        {
            string[] input = Console.ReadLine().Split(':');
            string[] words = input[1].Split(' ');
            short res;
            for (int i = 0; i < words.Length; i++)
            {
                if (Int16.TryParse(words[i], out res))
                {
                    int weightage = (input[0].Equals("G") ? 2 : 1);
                    if (chatNumMap.ContainsKey(res))
                        chatNumMap[res] = chatNumMap[res] + weightage;
                    else
                        chatNumMap.Add(res, weightage);
                }
            }
        }
        int maxWeightageDate = chatNumMap.FirstOrDefault(x => x.Value == chatNumMap.Values.Max()).Key;
        if (maxWeightageDate == 19 || maxWeightageDate == 20)
            Console.WriteLine("Date");
        else
            Console.WriteLine("No Date");
    }
}

