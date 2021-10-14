using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1319
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int[,] num = new int[N, N];
            int i, j, k, t, d = 1;

            k = 0;
            while (true)
            {
                if (k < N)
                {
                    i = 0;
                    j = N - k - 1;
                    t = N - 1;
                }
                else if (k < 2 * N - 1)
                {
                    i = k - N + 1;
                    j = 0;
                    t = N - i - 1;
                }
                else
                {
                    break;
                }
                while (j <= t)
                {
                    num[i++, j++] = d++;
                }
                k++;
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write(num[i, j]);
                    if (j != N - 1) Console.Write(" ");
                    else Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
