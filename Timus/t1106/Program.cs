using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1106
{
    class Program
    {
        static void bfs(List<int>[] g, int[] d, int v, int c)
        {
            if (d[v] == 0)
            {
                d[v] = c;
                if (c == 1) c = 2; else c = 1;
                foreach (int f in g[v]) bfs(g, d, f, c);
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            List<int>[] friends = new List<int>[N + 1];
            int[] distribution = new int[N + 1];
            int count2 = 0;
            int i;

            // Array of friends initialization
            friends[0] = new List<int>();
            for (i = 1; i <= N; i++)
            {
                friends[i] = new List<int>();
                string[] tokens = Console.ReadLine().Trim().Split(' ');
                for (int j = 0; j < tokens.Length - 1; j++) friends[i].Add(int.Parse(tokens[j]));
                friends[i].Sort();
            }

            for (i = 1; i <= N; i++)
            {
                if (distribution[i] == 0) bfs(friends, distribution, i, 1);
            }

            for (i = 1; i <= N; i++)
                if (distribution[i] == 2) count2++;
            Console.WriteLine(count2);
            for (i = 1; i <= N; i++)
                if (distribution[i] == 2) Console.Write("{0} ", i);
            Console.ReadLine();
        }
    }
}
