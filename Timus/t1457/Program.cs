using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1457
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            string[] tokens = Console.ReadLine().Split(' ');
            int s = 0;

            for (int i = 0; i < N; i++)
            {
                s += int.Parse(tokens[i]);
            }

            Console.WriteLine("{0:f6}", 1.0 * s / N);
            Console.ReadLine();
        }
    }
}
