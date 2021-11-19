using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1639
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int m = int.Parse(tokens[0]), n = int.Parse(tokens[1]);

            if ((m * n) % 2 == 0) Console.WriteLine("[:=[first]");
            else Console.WriteLine("[second]=:]");

            Console.ReadLine();
        }
    }
}
