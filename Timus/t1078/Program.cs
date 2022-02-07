using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1078
{
    class Program
    {
        static List<int>[] nesting;
        static (int count, string sequence)[] ss; // ss = "segments sequences"

        // True if segment "x" is nested in segment "y"
        static bool IsNested(int x1, int x2, int y1, int y2)
        {
            return (y1 < x1 && x2 < y2);
        }

        static (int, string) GetLongestSequence(int segnum)
        {
            if (ss[segnum].count != 0) return ss[segnum];

            (int count, string sequence) t1 = (0, ""), t2;
            foreach (int num in nesting[segnum])
            {
                t2 = GetLongestSequence(num);
                if (t2.count > t1.count) t1 = t2;
            }

            return (1 + t1.count, (segnum + 1).ToString() + " " + t1.sequence);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] t;
            nesting = new List<int>[n];
            (int, int)[] seg = new (int, int)[n];
            ss = new (int count, string sequence)[n];
            int i, j;
            int longest = 0;

            for (i = 0; i < n; i++)
            {
                t = Console.ReadLine().Split(' ');
                seg[i] = (int.Parse(t[0]), int.Parse(t[1]));
            }

            for (i = 0; i < n; i++)
            {
                nesting[i] = new List<int>();
                for (j = 0; j < n; j++)
                {
                    if (IsNested(seg[i].Item1, seg[i].Item2, seg[j].Item1, seg[j].Item2)) nesting[i].Add(j);
                }
            }

            for (i = 0; i < n; i++)
            {
                if (ss[i].count == 0) ss[i] = GetLongestSequence(i);
            }

            for (i = 1; i < n; i++)
            {
                if (ss[i].count > ss[longest].count) longest = i;
            }
            Console.WriteLine(ss[longest].count);
            Console.WriteLine(ss[longest].sequence.Trim());
            Console.ReadLine();
        }
    }
}
