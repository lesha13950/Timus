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
            BigInteger F = 0, F3, F4;

            if (N != 2)
            {
                F3 = (k - 1) * (k * k - 1);
                F4 = (k - 1) * (k * k - 1) * k - (k - 1) * (k - 1);
                if (N == 3) F = F3;
                else if (N == 4) F = F4;
                else
                {
                    for (int i = 4; i < N; i++)
                    {
                        F = (k - 1) * (F3 + F4);
                        F3 = F4;
                        F4 = F;
                    }
                }
            }
            
            Console.WriteLine(F);
            Console.ReadLine();
        }
    }
}
