using System;
using System.Collections;
class ArrayInsert
{
    public ArrayInsert()
    {
        string input = Console.ReadLine();
        string[] temp = input.Split(' ');
        int n = Convert.ToInt16(temp[0]);
        int q = Convert.ToInt16(temp[1]);

        input = Console.ReadLine();
        temp = input.Split(' ');

        int[] arr = new int[n];
        ArrayList output = new ArrayList();

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt16(temp[i]);
        }
        while (q-- > 0)
        {
            input = Console.ReadLine();
            temp = input.Split(' ');
            string ind = temp[0];
            int num1 = Convert.ToInt16(temp[1]);
            int num2 = Convert.ToInt16(temp[2]);
            int sum = 0;

            switch (ind)
            {
                case "1":
                    arr[num1] = num2;
                    break;
                case "2":
                    if (num1 >= n || num1 < 0 || num2 >= n || num2 < 0)
                        output.Add(-1);
                    else
                    {
                        sum = 0;
                        for (int i = num1; i <= num2; i++)
                        {
                            sum = sum + arr[i];
                        }
                        output.Add(sum);
                    }
                    break;
            }
        }
        foreach (int i in output)
        {
            Console.WriteLine(i);
        }
    }
}