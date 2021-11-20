using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace t1009
{
    class Program
    {
        static BigInteger pow(BigInteger n, int k)
        {
            BigInteger result = 1;
            for (int i = 0; i < k; i++) result *= n;
            return result;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim()), k = int.Parse(Console.ReadLine().Trim());
            BigInteger[] F = new BigInteger[16];

            // F[N] initialization
            F[0] = F[1] = 0;
            F[2] = 1;
            for (int i = 3; i < N; i++) F[i] = pow(k, i - 2) + (k - 1) * (F[i - 1] + F[i - 2]);

            Console.WriteLine((k - 1) * (pow(k, N - 1) - F[N - 1]));
            Console.ReadLine();
        }
    }
}
