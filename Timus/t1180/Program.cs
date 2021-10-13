using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace t1180
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine().Trim());
            BigInteger r = N % 3;

            if (r == 0)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("1");
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
