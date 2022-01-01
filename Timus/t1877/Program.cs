using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1877
{
    class Program
    {
        static void Main(string[] args)
        {
            int code1 = int.Parse(Console.ReadLine().Trim());
            int code2 = int.Parse(Console.ReadLine().Trim());

            if (code1 % 2 == 0 || code2 % 2 == 1) Console.WriteLine("yes");
            else Console.WriteLine("no");
            Console.ReadLine();
        }
    }
}
