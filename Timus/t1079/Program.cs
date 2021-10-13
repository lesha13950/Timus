using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1079
{
    class Program
    {
        private const int TestsMaxCount = 10;

        static int findMax(int[] a, int n)
        {
            int max = a[0];
            for (int i = 1; i <=n; i++)
            {
                if (a[i] > max) max = a[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] tests = new int[TestsMaxCount];
            int[] a = new int[100000];

            string test;
            int i = 0, ntests = 0;

            // Parse input
            do
            {
                test = Console.ReadLine().Trim();
                if (test != "0")
                {
                    tests[i++] = int.Parse(test);
                }
            } while (test != "0" && i < TestsMaxCount);
            ntests = i;

            //Generate the first 100000 members of the sequence
            a[0] = 0;
            a[1] = 1;
            for (i = 2; i < 100000; i++)
            {
                int ind;
                if (i % 2 == 0)
                {
                    ind = i / 2;
                    a[i] = a[ind];
                }
                else
                {
                    ind = (i - 1) / 2;
                    a[i] = a[ind] + a[ind + 1];
                }
            }

            for (i = 0; i < ntests; i++)
            {
                Console.WriteLine($"{findMax(a, tests[i])}");
            }
            Console.ReadLine();
        }
    }
}
