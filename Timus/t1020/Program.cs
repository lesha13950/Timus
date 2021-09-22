using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1020
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens;
            int count, i = 1;
            double radius, x0, y0, x1, y1, x2, y2, l = 0;

            tokens = Console.ReadLine().Split();
            count = int.Parse(tokens[0]);
            radius = double.Parse(tokens[1]);

            tokens = Console.ReadLine().Split();
            x0 = x1 = double.Parse(tokens[0]);
            y0 = y1 = double.Parse(tokens[1]);
            while (i < count)
            {
                tokens = Console.ReadLine().Split();
                x2 = double.Parse(tokens[0]);
                y2 = double.Parse(tokens[1]);
                l += Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                x1 = x2;
                y1 = y2;
                i++;
            }
            l += Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));
            l += 2 * Math.PI * radius;
            Console.WriteLine($"{l:f2}");
            Console.ReadLine();
        }
    }
}
