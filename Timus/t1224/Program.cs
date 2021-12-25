using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1224
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            ulong N = ulong.Parse(t[0]), M = ulong.Parse(t[1]);
            ulong turns;

            if (N <= M) turns = 2 * N - 2;
            else turns = 2 * M - 1;

            Console.WriteLine(turns);
            Console.ReadLine();
        }
    }
}
