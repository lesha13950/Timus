using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1032
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N], b = new int[N];
            int sum = 0;
            int i, j;

            // b - array of partial sums
            // initialization
            b[0] = -1;
            for (i = 1; i < N; i++) b[i] = -2;

            // read input array
            for (i = 0; i < N; i++) a[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++) {
                sum = (sum + a[i]) % N;
                if (b[sum] == -2) b[sum] = i;
                else
                {
                    Console.WriteLine(i - b[sum]);
                    for (j = b[sum] + 1; j <= i; j++) Console.WriteLine(a[j]);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
