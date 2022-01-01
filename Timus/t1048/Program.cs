using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1048
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            char[] a = new char[N], b = new char[N], s = new char[N];
            int ta, tb, c = 0, d;
            string t;
            int i;
            for (i = 0; i < N; i++)
            {
                if (i % 1000 == 0) GC.Collect();
                t = Console.ReadLine().Trim();
                a[i] = t[0];
                b[i] = t[2];
            }

            for (i = N - 1; i >= 0; i--)
            {
                if (i % 1000 == 0) GC.Collect();
                ta = a[i] - '0';
                tb = b[i] - '0';
                d = (ta + tb + c) % 10;
                c = (ta + tb + c) / 10;
                s[i] = (char)(d + '0');
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
