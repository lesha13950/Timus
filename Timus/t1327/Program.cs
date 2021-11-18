using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1327
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine().Trim());
            int B = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine(((B - A) + 1) / 2 + (A % 2 & B % 2));
            Console.ReadLine();
        }
    }
}
