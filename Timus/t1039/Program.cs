using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1039
{
    class Program
    {
        static List<int>[] staff;
        static int N;

        static int Maximize(List<int> l)
        {
            int max = int.MinValue;
            l.Sort();
            l.Reverse();
            max = l[0];
            for (int i = 1; i < l.Count; i++)
            {
                if (l[i] <= 0) break;
                max += l[i];
            }
            return max;
        }
        static int GetMaxMood(int st)
        {
            int max = int.MinValue;

            if (staff[st][0] != int.MinValue) max = staff[st][0];
            else if (staff[st].Count == 2)
            {
                max = staff[st][0] = staff[st][1];
            }
            else
            {
                List<int> l1 = new List<int>(), l2 = new List<int>();
                l1.Add(staff[st][1]);
                for (int i = 2; i < staff[st].Count; i++)
                {
                    int child = staff[st][i];
                    l2.Add(GetMaxMood(child));
                    for (int j = 2; j < staff[child].Count(); j++) l1.Add(GetMaxMood(staff[child][j]));
                }
                max = staff[st][0] = Math.Max(Maximize(l1), Maximize(l2));
            }
            return max;
        }

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            staff = new List<int>[N + 1];
            int i;
            for (i = 1; i <= N; i++)
            {
                staff[i] = new List<int>();
                staff[i].Add(int.MinValue);
                staff[i].Add(int.Parse(Console.ReadLine()));
            }
            for (i = 1; i < N; i++)
            {
                string[] t = Console.ReadLine().Trim().Split(' ');
                int l = int.Parse(t[0]), k = int.Parse(t[1]);
                staff[k].Add(l);
            }
            Console.ReadLine(); // Skip 0 0

            int max = 0;
            for (i = 1; i <= N; i++)
            {
                int tmp = GetMaxMood(i);
                if (tmp > max) max = tmp;
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
