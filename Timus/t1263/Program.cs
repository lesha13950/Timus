using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1263
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(t[0]), M = int.Parse(t[1]);
            int[] candidates = new int[N];
            int i;

            for (i = 0; i < M; i++)
            {
                int c = int.Parse(Console.ReadLine().Trim());
                candidates[c - 1]++;
            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("{0:f2}%", 100.0 * candidates[i] / M);
            }
            Console.ReadLine();
        }
    }
}
