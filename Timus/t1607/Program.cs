using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1607
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(t[0]), b = int.Parse(t[1]), c = int.Parse(t[2]), d = int.Parse(t[3]);
            int deal = 0;

            if (a >= c) deal = a;

            while (deal == 0)
            {
                if (a + b > c) deal = c; else a += b;
                if (deal == 0)
                {
                    if (c - d < a) deal = a; else c -= d;
                }
            }

            Console.WriteLine(deal);
            Console.ReadLine();
        }
    }
}
