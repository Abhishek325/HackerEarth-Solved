using System;
using System.Linq;
class doctors_secret
{
    public doctors_secret()
    {

        Int16[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt16(x)).ToArray();
        int name = input[0];
        int pages = input[1];
        if (name <= 23 && (pages <= 1000 && pages >= 500))
            Console.WriteLine("Take Medicine");
        else
            Console.WriteLine("Don't take Medicine");
    }
}
