using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1017
{
    class Program
    {
        static int Lmax(int N)
        {
            return (int)((Math.Sqrt(8 * N + 1) - 1) / 2);
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            ulong[,] Q = new ulong[N + 1, Lmax(N) + 1];
            ulong q = 0;
            int i, j;

            for (i = 1; i <= N; i++)
            {
                for (j = 1; j<= Lmax(N); j++)
                {
                    if (j == 1) Q[i, j] = 1;
                    else if (j > Lmax(i)) Q[i, j] = 0;
                    else Q[i, j] = Q[i - j, j] + Q[i - j, j - 1];
                }
            }

            for (j = 2; j <= Lmax(N); j++) q += Q[N, j];
            Console.WriteLine(q);
            Console.ReadLine();
        }
    }
}
