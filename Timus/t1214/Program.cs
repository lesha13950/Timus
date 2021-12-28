using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1214
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(t[0]), b = int.Parse(t[1]);
            int x = 0, y = 0;

            if (a <= 0 || b <= 0)
            {
                x = a;
                y = b;
            }
            else if ((a + b) % 2 == 0)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }

            Console.WriteLine("{0} {1}", x, y);
            Console.ReadLine();
        }
    }
}
