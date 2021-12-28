using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1203
{
    class Program
    {
        
        static void sort5(ulong[] R)
        {
            int[] c = new int[10], p = new int[10];
            int N = R.Length;
            ulong[] t = new ulong[N];
            ulong d;
            int i, j;
            ulong pos = 1;

            for (i = 0; i < 5; i++)
            {
                Array.Clear(c, 0, 10);
                Array.Clear(p, 0, 10);

                for (j = 0; j < N; j++)
                {
                    d = (R[j] / pos) % 10;
                    c[d]++;
                }

                for (j = 1; j < 10; j++) p[j] = p[j - 1] + c[j - 1];

                for (j = 0; j < N; j++)
                {
                    d = (R[j] / pos) % 10;
                    t[p[d]] = R[j];
                    p[d]++;
                }

                for (j = 0; j < N; j++)
                {
                    R[j] = t[j];
                }

                pos *= 10;
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            ulong[] R = new ulong[N];
            List<ulong> A = new List<ulong>();
            int i;

            for (i = 0; i < N; i++)
            {
                string[] t = Console.ReadLine().Trim().Split(' ');
                R[i] = ulong.Parse(t[0]) * 100000 + ulong.Parse(t[1]);
            }
            sort5(R);

            i = 0;
            while (i < N)
            {
                ulong f;
                A.Add(R[i]);
                f = R[i] % 100000;
                i++;
                while ((i < N) && ((R[i] / 100000) <= f)) i++;
            }

            Console.WriteLine(A.Count);
            Console.ReadLine();
        }
    }
}
