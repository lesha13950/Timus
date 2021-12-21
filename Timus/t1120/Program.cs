using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1120
{
    class Program
    {
        static void Main(string[] args)
        {
            long S = int.Parse(Console.ReadLine().Trim());
            List<long> N = new List<long>();
            double A = S; // trivial solution
            long nA = 1; // trivial solution

            // set of delimiters of 2S
            for (long i = (long)((1 + Math.Sqrt(8 * S + 1)) / 2); i >= 1; i--)
                if ((2 * S) % i == 0) N.Add(i);

            // check if expression S/Ni - (Ni-1)/2 is integer
            foreach (long n in N)
            {
                A = (double)S / n - ((double)n - 1) / 2;
                if (A <= 0) continue;
                if (A % 1 == 0)
                {
                    nA = n;
                    break;
                }
            }

            Console.WriteLine("{0} {1}", (long)A, nA);
            Console.ReadLine();
        }
    }
}
