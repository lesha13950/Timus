using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1228
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(tokens[0]), s = int.Parse(tokens[1]);
            int[] D = new int[n], k = new int[n];
            int i, cnt = 1;

            for (i = 0; i < n; i++)
            {
                D[i] = int.Parse(Console.ReadLine().Trim());
            }

            for (i = n - 1; i >= 1; i--)
            {
                cnt *= D[i - 1] / D[i];
                k[n - i - 1] = D[i - 1] / D[i] - 1;
            }
            k[n - 1] = s / cnt - 1;

            for (i = n-1; i >= 0; i--)
            {
                Console.Write(k[i]);
                if (i != 0) Console.Write(" ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
