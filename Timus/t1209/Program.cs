using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1209
{
    class Program
    {
        static int getDigit(ulong pos)
        {
            ulong Sk = pos - 1;
            double kd = (Math.Sqrt(1 + 8 * Sk) - 1) / 2;
            ulong k = (ulong)kd;
            ulong S = (k * k + k) / 2;
            if (Sk == S) return 1;
            return 0;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            ulong[] pos = new ulong[65535];
            int i;

            for (i = 0; i < n; i++)
            {
                pos[i] = ulong.Parse(Console.ReadLine().Trim());
            }

            for (i = 0; i < n; i++)
            {
                Console.Write(getDigit(pos[i]));
                if (i != n - 1) Console.Write(" ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
