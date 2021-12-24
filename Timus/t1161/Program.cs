using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1161
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int[] s = new int[N];
            int i;
            double min;

            for (i = 0; i < N; i++)
            {
                s[i] = int.Parse(Console.ReadLine().Trim());
            }

            Array.Sort(s);
            Array.Reverse(s);

            if (N == 1) min = s[0];
            else min = 2 * Math.Sqrt(s[0] * s[1]);
            for (i = 2; i < N; i++)
                min = 2 * Math.Sqrt(min * s[i]);
            Console.WriteLine("{0:f2}", min);
            Console.ReadLine();
        }
    }
}
