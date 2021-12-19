using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1110
{
    class Program
    {
        static uint mod_pow (uint X, uint N, uint M)
        {
            uint result = X % M;
            for (uint i = 1; i < N; i++)
            {
                result *= X % M;
                result %= M;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            uint N = uint.Parse(tokens[0]), M = uint.Parse(tokens[1]), Y = uint.Parse(tokens[2]);
            bool found = false;

            for (uint i = 0; i < M; i++)
            {
                if (mod_pow(i, N, M) == Y)
                {
                    if (found) Console.Write(' ');
                    else found = true;

                    Console.Write(i);
                }
            }
            if (!found) Console.WriteLine("-1");
            Console.ReadLine();
        }
    }
}
