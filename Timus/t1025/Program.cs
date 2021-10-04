using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1025
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens;
            int K, i, nmin = 0;
            int[] el;

            K = int.Parse(Console.ReadLine().Trim());
            tokens = Console.ReadLine().Trim().Split(' ');
            el = new int[K];
            for (i = 0; i < K; i++)
            {
                el[i] = int.Parse(tokens[i]);
            }

            Array.Sort(el);
            for (i = 0; i < K / 2 + 1; i++)
            {
                nmin += el[i] / 2 + 1;
            }
            Console.WriteLine(nmin);
            Console.ReadLine();
        }
    }
}
