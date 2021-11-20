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
            int N = int.Parse(Console.ReadLine().Trim()), k = int.Parse(Console.ReadLine().Trim());
            BigInteger F = 0, F2, F3;

            F2 = k * k - k;
            F3 = (k - 1) * (k * k - 1);
            if (N == 2) F = F2;
            else if (N == 3) F = F3;
            else
            {
                for (int i = 3; i < N; i++)
                {
                    F = (k - 1) * (F2 + F3);
                    F2 = F3;
                    F3 = F;
                }
            }

            Console.WriteLine(F);
            Console.ReadLine();
        }
    }
}
