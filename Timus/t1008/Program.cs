using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1008
{
    class Program
    {
        static int[,] IMG = new int[11, 11];
        static int BN = 0;

        static void PrintFirst()
        {
            Console.WriteLine(BN);
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (IMG[11 - j, i] != 0) Console.WriteLine("{0} {1}", i, j);
                }
            }
        }

        static void ConvertToSecond(int x, int y)
        {
            int n = 1;
            Queue<int> q = new Queue<int>();
            q.Enqueue(x);
            q.Enqueue(y);
            IMG[11 - y, x] = 2;
            Console.WriteLine("{0} {1}", x, y);
            while (n <= BN)
            {
                int cx = q.Dequeue(), cy = q.Dequeue();
                if (cx + 1 <= 10 && IMG[11 - cy, cx + 1] == 1)
                {
                    Console.Write('R');
                    q.Enqueue(cx + 1);
                    q.Enqueue(cy);
                    IMG[11 - cy, cx + 1] = 2;
                }
                if (11 - cy - 1 >= 1 && IMG[11 - cy - 1, cx] == 1)
                {
                    Console.Write('T');
                    q.Enqueue(cx);
                    q.Enqueue(cy + 1);
                    IMG[11 - cy - 1, cx] = 2;
                }
                if (cx - 1 >= 1 && IMG[11 - cy, cx - 1] == 1)
                {
                    Console.Write('L');
                    q.Enqueue(cx - 1);
                    q.Enqueue(cy);
                    IMG[11 - cy, cx - 1] = 2;
                }
                if (11 - cy + 1 <= 10 && IMG[11 - cy + 1, cx] == 1)
                {
                    Console.Write('B');
                    q.Enqueue(cx);
                    q.Enqueue(cy - 1);
                    IMG[11 - cy + 1, cx] = 2;
                }
                if (n < BN) Console.WriteLine(','); else Console.WriteLine('.');
                n++;
            }
        }
        static void Main(string[] args)
        {
            int lx = 0, by = 0;
            int i;
            string[] t = Console.ReadLine().Split(' ');
            if (t.Length == 1)
            {
                BN = int.Parse(t[0]);
                for (i = 0; i < BN; i++)
                {
                    t = Console.ReadLine().Split(' ');
                    IMG[11 - int.Parse(t[1]), int.Parse(t[0])] = 1;
                    if (i == 0)
                    {
                        lx = int.Parse(t[0]);
                        by = int.Parse(t[1]);
                    }
                }
                ConvertToSecond(lx, by);
            }
            else
            {
                Queue<int> q = new Queue<int>();
                q.Enqueue(int.Parse(t[0]));
                q.Enqueue(int.Parse(t[1]));
                while (q.Count != 0)
                {
                    int cx = q.Dequeue(), cy = q.Dequeue();
                    IMG[11 - cy, cx] = 1;
                    BN++;
                    string s = Console.ReadLine().Trim();
                    for (i = 0; i < s.Length; i++)
                    {
                        if (s[i] == 'R')
                        {
                            q.Enqueue(cx + 1);
                            q.Enqueue(cy);
                        }
                        if (s[i] == 'T')
                        {
                            q.Enqueue(cx);
                            q.Enqueue(cy + 1);
                        }
                        if (s[i] == 'L')
                        {
                            q.Enqueue(cx - 1);
                            q.Enqueue(cy);
                        }
                        if (s[i] == 'B')
                        {
                            q.Enqueue(cx);
                            q.Enqueue(cy - 1);
                        }
                    }
                }
                PrintFirst();
            }

            Console.ReadLine();
        }
    }
}
