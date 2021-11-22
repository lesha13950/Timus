using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace t1017
{
    class Program
    {
        static BigInteger Q = 0;

        static void q(int h, int rest)
        {
            int l, r;

            if (h >= rest) return;

            l = h + 1;
            r = rest - l;
            while (l < r)
            {
                Q++;
                q(l, r);
                l += 1;
                r -= 1;
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());

            q(0, N);
            Console.WriteLine(Q);
            Console.ReadLine();
        }
    }
}
