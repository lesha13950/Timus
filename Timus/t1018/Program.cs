using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1018
{
    class Program
    {
        static int[,] F;
        static int[] T;

        static int f(int p, int k)
        {
            int max = 0, val;
            int l = T[p * 5 + 1], r = T[p * 5 + 3], lw = T[p * 5 + 2], rw = T[p * 5 + 4];

            if (k == 1) return Math.Max(lw, rw);
            if ((F[p, k - 1] == 0) || (l == 0 && r == 0)) return 0;
            if (l == 0)
                if (F[r, k - 1] == 0) return 0; else return F[r, k - 1] + rw;
            if (r == 0)
                if (F[l, k - 1] == 0) return 0; else return F[l, k - 1] + lw;

            for (int i = 1; i <= k + 1; i++)
            {
                if (i <= k - 1 && F[l, k - i] == 0) continue;
                if (i >= 3 && F[r, i - 2] == 0) break;
                val = (i == k + 1 ? 0 : F[l, k - i] + lw) + (i == 1 ? 0 : rw + F[r, i - 2]);
                if (val > max) max = val;
            }
            return max;
        }
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int P = int.Parse(t[0]), Q = int.Parse(t[1]);
            F = new int[P + 1, P];
            T = new int[(P + 1) * 5];
            int i, j;

            // Tree initialization
            T[5] = 1;
            for (i = 0; i < P - 1; i++)
            {
                t = Console.ReadLine().Trim().Split(' ');
                int a = int.Parse(t[0]), b = int.Parse(t[1]), c = int.Parse(t[2]);
                int parent, child, shift = 0;
                if (T[a * 5] == 1)
                {
                    parent = a;
                    child = b;
                }
                else
                {
                    parent = b;
                    child = a;
                }
                if (T[parent * 5 + 1] != 0) shift = 2;
                T[parent * 5 + 1 + shift] = child;
                T[parent * 5 + 2 + shift] = c;
                T[child * 5] = 1;
            }

            // Filling F table
            for (i = 1; i <= Q; i++)
            {
                for (j = 1; j <= P; j++)
                {
                    F[j, i] = f(j, i);
                }
            }
            Console.WriteLine(F[1, Q]);
            Console.ReadLine();
        }
    }
}
