using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1024
{
    class Program
    {
        static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        static int lcm(int a, int b)
        {
            return a * b / gcd(a, b);
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Trim().Split(' ');
            int[] P = new int[N + 1];
            int[] SPC = new int[N];
            int k;
            int i, j;
            for (i = 1; i <= N; i++) P[i] = int.Parse(t[i - 1]);

            i = 1;
            j = 0;
            while (i <= N)
            {
                if (P[i] == 0) i++;
                else
                {
                    int first = i, next = i;
                    do {
                        int prev = next;
                        SPC[j]++;
                        next = P[next];
                        P[prev] = 0;
                    } while (next != first);
                    j++;
                }
            }

            k = SPC[0];
            for (i = 1; i < N; i++)
            {
                if (SPC[i] == 0) break;
                k = lcm(k, SPC[i]);
            }
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
