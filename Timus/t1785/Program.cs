using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1785
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            if (n <= 4) Console.WriteLine("few");
            else if (n <= 9) Console.WriteLine("several");
            else if (n <= 19) Console.WriteLine("pack");
            else if (n <= 49) Console.WriteLine("lots");
            else if (n <= 99) Console.WriteLine("horde");
            else if (n <= 249) Console.WriteLine("throng");
            else if (n <= 499) Console.WriteLine("swarm");
            else if (n <= 999) Console.WriteLine("zounds");
            else Console.WriteLine("legion");
            Console.ReadLine();
        }
    }
}
