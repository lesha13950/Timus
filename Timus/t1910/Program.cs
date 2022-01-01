using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1910
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int[] a = new int[n];
            int imax = 0, max = 0;
            int i;
            string[] t = Console.ReadLine().Trim().Split(' ');
            for (i = 0; i < n; i++) a[i] = int.Parse(t[i]);

            for (i = 0; i < n - 2; i++)
            {
                if (a[i] + a[i + 1] + a[i + 2] > max)
                {
                    max = a[i] + a[i + 1] + a[i + 2];
                    imax = i;
                }
            }

            Console.WriteLine("{0} {1}", max, imax + 2);
            Console.ReadLine();
        }
    }
}
