using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace t1012
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine().Trim()), k = BigInteger.Parse(Console.ReadLine().Trim());
            BigInteger M = BigInteger.Parse(Console.ReadLine().Trim());
            BigInteger F2, F3; // vector F
            BigInteger F = -1; //result
            BigInteger a = 0, b = 1, c, d; // matrix

            c = d = k - 1;

            F2 = (k * k - k) % M;
            F3 = ((k - 1) * (k * k - 1)) % M ;

            if (N == 2) F = F2;
            else if (N == 3) F = F3;
            else
            {
                BigInteger p = N - 3;
                while (p > 0)
                {
                    if ((p & 1) == 1)
                    {
                        BigInteger tF2 = F2;
                        F2 = (a * F2 + b * F3) % M;
                        F3 = (c * tF2 + d * F3) % M;
                    }
                    BigInteger ta = a, tb = b, tc = c;
                    a = (a * a + b * c) % M;
                    b = (ta * b + b * d) % M;
                    c = (c * ta + d * c) % M;
                    d = (tc * tb + d * d) % M;

                    p >>= 1;
                }
                F = F3;
            }

            Console.WriteLine(F);
            Console.ReadLine();
        }
    }
}
