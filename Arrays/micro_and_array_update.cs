using System;

namespace HackerEarth.Arrays
{
    class micro_and_array_update
    {
        public micro_and_array_update()
        {
            execute();
        }
        public void execute()
        {
            int noOFTestCases = Convert.ToInt32(Console.ReadLine());
            Int32[] output = new Int32[noOFTestCases];
            while (noOFTestCases-- > 0)
            {
                string input = Console.ReadLine();
                string[] tempArr = input.Split(' ');
                int n = Convert.ToInt32(tempArr[0]);
                int k = Convert.ToInt32(tempArr[1]);
                int[] arr = new int[n];
                input = Console.ReadLine();
                tempArr = input.Split(' ');
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(tempArr[i]);
                }
                Int32 min = arr[0];
                for (int i = 1; i < n; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];
                }
                output[noOFTestCases] = (k > min) ? (k - min) : 0;
            }
            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
