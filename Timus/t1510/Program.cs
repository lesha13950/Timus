using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1510
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int nominal = -1;
            int cur;
            int c = 0;

            for (int i = 0; i < N; i++)
            {
                if (i % 1000 == 0) GC.Collect();
                cur = int.Parse(Console.ReadLine());
                if (c == 0)
                {
                    nominal = cur;
                    c = 1;
                }
                else if (cur == nominal)
                {
                    c++;
                }
                else
                {
                    c--;
                }
            }
            Console.WriteLine(nominal);
            Console.ReadLine();
        }
    }
}
