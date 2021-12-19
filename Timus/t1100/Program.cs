using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1100
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            uint[] x = new uint[N];
            int i, j;
            for (i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Trim().Split(' ');
                x[i] = (uint.Parse(tokens[0]) << 8) + uint.Parse(tokens[1]);
            }

            for (i = 100; i >= 0; i--)
            {
                for (j = 0; j < N; j++)
                {
                    if ((x[j] & 0xFF) == i) Console.WriteLine("{0} {1}", x[j] >> 8, i);
                }
            }
            Console.ReadLine();
        }
    }
}
