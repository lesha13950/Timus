using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1260
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int[] F = new int[56];
            F[0] = 0;
            F[1] = 1;
            F[2] = 1;
            for (int i = 3; i <= N; i++) F[i] = F[i - 1] + F[i - 3] + 1;

            Console.WriteLine(F[N]);
            Console.ReadLine();
        }
    }
}
