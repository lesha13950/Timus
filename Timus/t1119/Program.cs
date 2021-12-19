using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1119
{
    class Program
    {
        static double min3(double a, double b, double c)
        {
            double result = a;
            if (b < result) result = b;
            if (c < result) result = c;
            return result;
        }
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(tokens[0]), M = int.Parse(tokens[1]);
            int K = int.Parse(Console.ReadLine().Trim());
            bool[,] diag= new bool[M, N];
            double[,] dist = new double[M + 1, N + 1];
            double el = 100, dl = 100 * Math.Sqrt(2);
            int i, j;

            for (i = 0; i < K; i++)
            {
                int n, m;
                tokens = Console.ReadLine().Trim().Split(' ');
                n = int.Parse(tokens[0]);
                m = int.Parse(tokens[1]);
                diag[M - m, n - 1] = true;
            }

            dist[M, 0] = 0;
            for (i = M; i >= 0; i--)
            {
                for (j = 0; j <= N; j++)
                {
                    double lw, ls, lws;
                    if (i == M && j == 0) continue;
                    lw = ls = lws = 2000 * el;
                    if (j > 0) lw = dist[i, j - 1] + el;
                    if (i < M) ls = dist[i + 1, j] + el;
                    if (j > 0 && i < M)
                        if (diag[i, j - 1]) lws = dist[i + 1, j - 1] + dl;
                    dist[i, j] = min3(lw, ls, lws);
                }
            }

            Console.WriteLine((int)(dist[0, N] + 0.5));
            Console.ReadLine();
        }
    }
}
