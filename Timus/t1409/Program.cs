using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1409
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int a = int.Parse(tokens[0]), b = int.Parse(tokens[1]);

            Console.WriteLine("{0} {1}", b - 1, a - 1);
            Console.ReadLine();
        }
    }
}
