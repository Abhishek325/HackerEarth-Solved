using System;
class MinMax
{
    public MinMax()
    {
        string input = Console.ReadLine();
        int n = Convert.ToInt16(input);

        input = Console.ReadLine();
        string[] temp = input.Split(' ');
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt16(temp[i]);
        }
        arr = sort(arr);
        int min = arr[0], max = arr[n - 1], diff = 0;
        for (int i = 1; i < n; i++)
        {
            diff = arr[i] - arr[i - 1];
            if (diff != 1 && diff != 0)
            {
                Console.Write("NO");
                return;
            }
        }
        Console.Write("YES");
    }
    public int[] sort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }
}