using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1080
{
    class Program
    {
        static int[,] land; // land[i, 0] = -1 (unpainted), 0 (red) or 1(blue)
        static int N;
        static bool success = true;

        static void paint(int n, int color)
        {
            
            if (!success) return;
            if (land[n, 0] == color) return;
            if (land[n, 0] == -1)
            {
                land[n, 0] = color;
                int nextcolor = (color + 1) % 2;
                for (int i = 1; i <= N; i++)
                {
                    if (land[n, i] == 1) paint(i, nextcolor);
                }
            }
            else
            {
                success = false;
            }
        }
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            string[] t;
            int i, j;
            // List of lands initialization; land[0] not in use
            land = new int[N + 1, N + 1];
            for (i = 1; i <= N; i++)
            {
                land[i, 0] = -1; // mark each land as unpainted
                t = Console.ReadLine().Trim().Split(' ');
                for (j = 0; j < t.Length - 1; j++)
                {
                    int nl = int.Parse(t[j]);
                    land[i, nl] = 1;
                    land[nl, i] = 1;
                }
            }

            paint(1, 0);

            if (!success) Console.WriteLine("-1");
            else
            {
                for (i = 1; i <= N; i++) Console.Write(land[i, 0]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
