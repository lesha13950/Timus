using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1585
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int e, l, m, max;

            e = l = m = 0;
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine().Trim();
                if (s[0] == 'E') e++;
                if (s[0] == 'M') m++;
                if (s[0] == 'L') l++;
            }

            max = e;
            if (l > max) max = l;
            if (m > max) max = m;

            if (max == e) Console.WriteLine("Emperor Penguin");
            if (max == l) Console.WriteLine("Little Penguin");
            if (max == m) Console.WriteLine("Macaroni Penguin");
            Console.ReadLine();
        }
    }
}
