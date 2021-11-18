using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1349
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1) Console.WriteLine("1 2 3");
            else if (n == 2) Console.WriteLine("3 4 5");
            else Console.WriteLine("-1");
            Console.ReadLine();
        }
    }
}
