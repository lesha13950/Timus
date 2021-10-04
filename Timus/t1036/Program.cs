using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace t1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(tokens[0]), S = int.Parse(tokens[1]);
            BigInteger[] vars1 = new BigInteger[451], vars2 = new BigInteger[451];
            int i, j, k, b;

            if (S > N * 18 || S % 2 == 1)
            {
                Console.WriteLine("0");
                Console.ReadLine();
                return;
            }

            S /= 2;

            vars1[0] = 1;
            for (i = 1; i < 451; i++)
            {
                vars1[i] = 0;
            }

            for (i = 1; i <= N; i++)
            {
                for (j = 0; j <= i * 9; j++)
                {
                    b = j - 9;
                    if (b < 0)
                    {
                        b = 0;
                    }
                    vars2[j] = 0;
                    for (k = b; k <= j; k++)
                    {
                        vars2[j] += vars1[k];
                    }
                }
                for (j = 0; j <= i * 9; j++)
                {
                    vars1[j] = vars2[j];
                }
            }

            Console.WriteLine($"{vars1[S] * vars1[S]}");
            Console.ReadLine();
        }
    }
}
