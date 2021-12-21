using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1194
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(t[0]), K = int.Parse(t[1]);
            Console.In.ReadToEnd();

            Console.WriteLine((N - 1) * N / 2 - K);
            Console.ReadLine();
        }
    }
}
