using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1011
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong p, q;
            ulong c, n;
            string[] t = Console.ReadLine().Trim().Split(' ');
            string ps = t[0], qs;
            if (t.Length == 2)
            {
                qs = t[1];
            }
            else
            {
                qs = Console.ReadLine().Trim();
            }
            int point = ps.IndexOfAny(new char[] { '.', ',' });
            if (point == -1)
            {
                p = ulong.Parse(ps) * 100;
            }
            else
            {
                t = ps.Split(new char[] { '.', ',' });
                p = t[1].Length == 2 ? ulong.Parse(t[1]) : ulong.Parse(t[1]) * 10;
                p += ulong.Parse(t[0]) * 100;
            }
            point = qs.IndexOfAny(new char[] { '.', ',' });
            if (point == -1)
            {
                q = ulong.Parse(qs) * 100;
            }
            else
            {
                t = qs.Split(new char[] { '.', ',' });
                q = t[1].Length == 2 ? ulong.Parse(t[1]) : ulong.Parse(t[1]) * 10;
                q += ulong.Parse(t[0]) * 100;
            }
            p *= 10;
            q *= 10;

            n = 2;
            while (true)
            {
                c = n * p / 100000 + 1;
                if (100000 * c / n < q) break;
                n++;
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
