using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1638
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int wt = int.Parse(tokens[0]);
            int wp = int.Parse(tokens[1]);
            int first = int.Parse(tokens[2]);
            int last = int.Parse(tokens[3]);

            if (last == first) Console.WriteLine(wt);
            else if (last > first) Console.WriteLine((last - first - 1) * (wt + 2 * wp) + 2 * wp);
            else Console.WriteLine((first - last + 1) * wt + (first - last) * wp * 2);
            Console.ReadLine();
        }
    }
}
