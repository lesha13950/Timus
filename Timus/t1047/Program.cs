using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1047
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int N = int.Parse(Console.ReadLine());
            double a0 = double.Parse(Console.ReadLine()), aN1 = double.Parse(Console.ReadLine());
            double C = 0;
            int i;
            for (i = 0; i < N; i++) C += (N - i) * double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", (aN1 + N * a0 - 2 * C) / (N + 1));
            Console.ReadLine();
        }
    }
}
