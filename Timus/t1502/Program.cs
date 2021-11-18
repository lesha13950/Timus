using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1502
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine().Trim());
            ulong sum = 0;

            for (ulong i = 0; i <= N; i++) sum += (N - i + 1) * (3 * i + N) / 2;

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
