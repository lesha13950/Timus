using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = 0;
            long maxSlope = 0; ;
            long f1 = long.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                long f2 = long.Parse(Console.ReadLine());
                long slope = Math.Abs(f2 - f1);
                if (slope > maxSlope)
                {
                    maxSlope = slope;
                    A = i - 1;
                }
                f1 = f2;
                if (i % 1000 == 0) GC.Collect();
            }

            Console.WriteLine("{0} {1}", A + 1, A + 2);
            Console.ReadLine();
        }
    }
}
