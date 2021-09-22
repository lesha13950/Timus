using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1005
{
    class Program
    {
        static int N;
        static int[] W;
        static double M;
        static bool minFounded;
        static double minClause;
        static double minDelta;
        static void resolve(int start, int sum)
        {
            double delta;

            if (minFounded) return;

            delta = Math.Abs(sum - M);
            if (delta == minClause)
            {
                minDelta = minClause;
                minFounded = true;
                return;
            }

            if (delta > minDelta && sum > M) return;

            if (delta < minDelta) minDelta = delta;

            for (int i = start + 1; i < N; i++)
            {
                resolve(i, sum + W[i]);
            }
        }
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int i, sum = 0;

            N = int.Parse(tokens[0]);
            W = new int[20];

            for (i = 0; i < N; i++)
            {
                W[i] = int.Parse(tokens[i + 1]);
            }

            for (i = 0; i < N; i++)
            {
                sum += W[i];
            }
            
            minClause = sum % 2 / 2.0;
            M = sum / 2.0;
            minDelta = M;
            minFounded = false;
            resolve(0, W[0]);

            Console.WriteLine(minDelta * 2);
            Console.ReadLine();
        }
    }
}
