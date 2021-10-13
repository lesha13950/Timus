using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1073
{
    
    class Program
    {
        static int minCount;
        static bool[] touched = new bool[60001];

        static void solve(int N, int count)
        {
            int a, i;

            if (N == 0)
            {
                if (count < minCount)
                {
                    minCount = count;
                }
                return;
            }

            if (count >= minCount) return;

            if (touched[N]) return;
            touched[N] = true;

            a = (int)Math.Sqrt(N);
            for (i = a; i >= 1; i--)
            {
                solve(N - i * i, count + 1);
                if (N - i * i == 0) break;
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < 60001; i++) touched[i] = false;
            minCount = N;

            solve(N, 0);

            Console.WriteLine(minCount);
            Console.ReadLine();
        }
    }
}
