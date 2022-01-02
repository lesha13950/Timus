using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] a = new int[N][];
            int max = 2, count;
            string[] t;
            int i, j, k;
            for (i = 0; i < N; i++)
            {
                t = Console.ReadLine().Trim().Split(' ');
                a[i] = new int[2];
                a[i][0] = int.Parse(t[0]);
                a[i][1] = int.Parse(t[1]);
            }

            for (i = 0; i < N - 2; i++)
            {
                int x1 = a[i][0], y1 = a[i][1];
                for (j = i + 1; j < N - 1; j++)
                {
                    int x2 = a[j][0], y2 = a[j][1];
                    count = 2;
                    for (k = j + 1; k < N; k++)
                    {
                        if ((a[k][0] - x1) * (y2 - y1) == (a[k][1] - y1) * (x2 - x1)) count++;
                    }
                    if (count > max) max = count;
                }
                
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
