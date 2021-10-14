using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1313
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int[,] pix = new int[N,N];
            int i, j, k, t;
            
            for (i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Trim().Split(' ');
                for (j = 0; j < N; j++)
                {
                    pix[i, j] = int.Parse(tokens[j]);
                }
            }

            k = 0;
            while (true)
            {
                if (k < N)
                {
                    i = k;
                    j = 0;
                    t = i;
                }
                else if (k < 2 * N - 1)
                {
                    i = N - 1;
                    j = k - N + 1;
                    t = N - 1;
                }
                else
                {
                    break;
                }
                while (j <= t)
                {
                    Console.Write(pix[i--, j++]);
                    if (i != N - 1 || j != N - 1) Console.Write(" ");
                }
                k++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
