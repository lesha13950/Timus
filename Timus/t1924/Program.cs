using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1924
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            if (n % 4 == 1 || n % 4 == 2) Console.WriteLine("grimy");
            else Console.WriteLine("black");
            Console.ReadLine();
        }
    }
}
