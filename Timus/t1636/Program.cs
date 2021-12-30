using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1636
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int Q = int.Parse(t[0]), Z = int.Parse(t[1]);
            t = Console.ReadLine().Trim().Split(' ');
            for (int i = 0; i < 10; i++)
            {
                Z -= 20 * int.Parse(t[i]);
            }
            if (Z < Q) Console.WriteLine("Dirty debug :(");
            else Console.WriteLine("No chance.");
            Console.ReadLine();
        }
    }
}
