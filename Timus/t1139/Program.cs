using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1139
{
    class Program
    {
        public const double e = 0.000001;
        static int ytc(double y1, double y2)
        {
            int c = 0;
            int A = (int)(y1 + e) + 1, B = (int)(y2 - e);
            if (B >= A) c = B - A + 1;
            return c;
        }
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int X = int.Parse(tokens[0]) - 1, Y = int.Parse(tokens[1]) - 1;
            double k = (double)Y / X;
            int c = 0;
            
            for (int i = 1; i <= X; i++)
            {
                c += 1 + ytc(k * (i - 1), k * i);
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
