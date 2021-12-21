using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1146
{
    class Program
    {
        static int d1max(int[,] a, int n, int l, int h)
        {
            int max_so_far = 0, max_ending = 0;

            for (int i = 0; i < n; i++)
            {
                int end = 0;
                for (int j = 0; j < h; j++) end += a[i, l + j];
                max_ending = Math.Max(0, max_ending + end);
                max_so_far = Math.Max(max_so_far, max_ending);
            }
            return max_so_far;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int i, j, h;
            int max = -128;
            int[,] A = new int[N, N];
            for (i = 0; i < N; i++)
            {
                string[] t = Console.ReadLine().Trim().Split(' ');
                for (j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(t[j]);
                    if (A[i, j] > max) max = A[i, j];
                }
            }

            if (max >= 0)
            {
                for (h = 1; h <= N; h++)
                {
                    for (i = 0; i <= N - h; i++)
                        max = Math.Max(max, d1max(A, N, i, h));
                }
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
