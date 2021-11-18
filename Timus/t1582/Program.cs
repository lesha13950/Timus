using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1582
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] tokens = Console.ReadLine().Trim().Split(' ');
            double k1 = double.Parse(tokens[0]), k2 = double.Parse(tokens[1]), k3 = double.Parse(tokens[2]);

            Console.WriteLine((int)(0.5 + 1000 * k1 * k2 * k3 / (k1 * k2 + k2 * k3 + k1 * k3)));
            Console.ReadLine();
        }
    }
}
