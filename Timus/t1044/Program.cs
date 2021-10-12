using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics;

namespace t1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
//          BigInteger[] vars1 = new BigInteger[451], vars2 = new BigInteger[451];
            ulong[] vars1 = new ulong[37], vars2 = new ulong[37];
            ulong count = 0;
            int i, j, k, b;

            if (N % 2 == 1)
            {
                Console.WriteLine("0");
                Console.ReadLine();
                return;
            }

            N /= 2;

            vars1[0] = 1;
            for (i = 1; i < 37; i++)
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

            for (i = 0; i < 37; i++)
            {
                count += vars1[i] * vars1[i];
            }
            Console.WriteLine($"{count}");
            Console.ReadLine();
        }
    }
}