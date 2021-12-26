using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1296
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, max = 0;
            int N = int.Parse(Console.ReadLine().Trim());
            int[] A = new int[N];
            int i;
            for (i = 0; i < N; i++) A[i] = int.Parse(Console.ReadLine().Trim());

            for (i = 0; i < N; i++)
            {
                sum = Math.Max(sum + A[i], 0);
                max = Math.Max(max, sum);
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
