using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1243
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine().Trim();
            int res = 0;
            int m = 1;

            for (int i = N.Length - 1; i >= 0; i--)
            {
                int d = N[i] - '0';
                res += m * d;
                m *= 3;
                m %= 7;
                res %= 7;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
