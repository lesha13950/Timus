using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1820
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(t[0]), k = int.Parse(t[1]);
            if (k >= n) Console.WriteLine("2");
            else Console.WriteLine(Math.Ceiling(2.0 * n / k));
            Console.ReadLine();
        }
    }
}
