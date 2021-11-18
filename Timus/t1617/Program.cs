using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1617
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int[] d = new int[101];
            int v = 0;
            int i;

            for (i = 0; i < N; i++)
            {
                int t = int.Parse(Console.ReadLine().Trim());
                d[t - 600]++;
            }

            for (i = 0; i <= 100; i++) v += d[i] / 4;

            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
