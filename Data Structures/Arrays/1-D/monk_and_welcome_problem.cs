using System;
namespace HackerEarth.Arrays
{
    class monk_and_welcome_problem
    {
        public monk_and_welcome_problem()
        {
            execute();
        }
        public void execute()
        {
            Int32 N = Convert.ToInt32(Console.ReadLine());
            Int32[] A = new Int32[N];
            Int32[] B = new Int32[N];
            Int32[] C = new Int32[N];

            string input = Console.ReadLine();
            string[] temp = input.Split(' ');
            int len = temp.Length;

            for (int k = 0; k < len; k++)
            {
                A[k] = Convert.ToInt32(temp[k]);
            }

            input = Console.ReadLine();
            temp = input.Split(' ');

            for (int k = 0; k < len; k++)
            {
                B[k] = Convert.ToInt32(temp[k]);
            }

            for (int k = 0; k < N; k++)
            {
                C[k] = A[k] + B[k];
            }

            for (int k = 0; k < N; k++)
            {
                Console.Write(C[k] + " ");
            }
        }
    }
}
