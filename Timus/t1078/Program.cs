using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1078
{
    class Program
    {
        // True if segment "x" is nested in segment "y"
        static bool IsNested(int x1, int x2, int y1, int y2)
        {
            return (y1 < x1 && x2 < y2);
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] nesting = new List<int>[n];
            int[] include = new int[n], topo = new int[n], cnt = new int[n], pos = new int[n];
            (int, int)[] seg = new (int, int)[n];
            (int count, string sequence)[] ss = new (int count, string sequence)[n]; // ss = "segments sequences"
            int i, j;
            int longest = 0;

            for (i = 0; i < n; i++)
            {
                string[] t = Console.ReadLine().Split(' ');
                seg[i] = (int.Parse(t[0]), int.Parse(t[1]));
            }

            for (i = 0; i < n; i++)
            {
                nesting[i] = new List<int>();
                for (j = 0; j < n; j++)
                {
                    if (IsNested(seg[i].Item1, seg[i].Item2, seg[j].Item1, seg[j].Item2))
                    {
                        nesting[i].Add(j);
                        include[j]++;
                    }
                }
            }
            for (i = 0; i < n; i++) cnt[include[i]]++;
            pos[0] = 0;
            for (i = 1; i < n; i++) pos[i] = pos[i - 1] + cnt[i - 1];
            for (i = 0; i < n; i++)
            {
                int ci = include[i];
                topo[pos[ci]++] = i;
            }

            // ss-array initialization
            for (i = 0; i < n; i++)
            {
                ss[i].count = 1;
                ss[i].sequence = (i + 1).ToString();
            }

            for (i = 0; i < n; i++)
            {
                int u = topo[i];
                foreach (int v in nesting[u])
                {
                    if (ss[v].count < ss[u].count + 1)
                    {
                        ss[v].count = ss[u].count + 1;
                        ss[v].sequence = ss[u].sequence + " " + (v + 1).ToString();
                    }
                }
            }

            for (i = 1; i < n; i++)
            {
                if (ss[i].count > ss[longest].count) longest = i;
            }
            Console.WriteLine(ss[longest].count);
            Console.WriteLine(ss[longest].sequence);
            Console.ReadLine();
        }
    }
}
