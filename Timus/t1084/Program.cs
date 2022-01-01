using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1084
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            double a = double.Parse(t[0]), l = double.Parse(t[1]);
            double s = 0;

            if (l <= a / 2)
                s = Math.PI * l * l;
            else if (l < a / Math.Sqrt(2))
            {
                double alpha = Math.PI / 2 - 2 * Math.Acos(a / (2 * l));
                s = 2 * alpha * l * l + a * Math.Sqrt(4 * l * l - a * a);
            }
            else s = a * a;
            Console.WriteLine("{0:f3}", s);
            Console.ReadLine();
        }
    }
}
