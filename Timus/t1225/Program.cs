using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1225
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim()), n = 3;
            ulong M1 = 1, M2 = 1, M = 0;

            if (N == 1) M = M1;
            else if (N == 2) M = M2;
            else
            {
                while (n <= N)
                {
                    M = M1 + M2;
                    M1 = M2;
                    M2 = M;
                    n++;
                }
            }
            Console.WriteLine(M * 2);
            Console.ReadLine();
        }
    }
}
