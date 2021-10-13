using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1082
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < N; i++)
            {
                Console.Write(i);
                if (i != N - 1) Console.Write(" ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
