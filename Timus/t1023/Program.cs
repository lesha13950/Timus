using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1023
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine().Trim());
            int L = 3;

            while (K % L != 0) L++;
            Console.WriteLine(L - 1);
            Console.ReadLine();
        }
    }
}
