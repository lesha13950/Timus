using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1053
{
    class Program
    {
        static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int l, g, i;
            g = int.Parse(Console.ReadLine());
            for (i = 1; i < N; i++)
            {
                l = int.Parse(Console.ReadLine());
                g = gcd(g, l);
            }
            Console.WriteLine(g);
            Console.ReadLine();
        }
    }
}
