using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t;
            int[] a = new int[3], b = new int[3];
            for (int i = 0; i < 3; i++)
            {
                t = Console.ReadLine().Trim().Split(' ');
                a[i] = int.Parse(t[0]);
                b[i] = int.Parse(t[1]);
            }
            Console.WriteLine("{0} {1}", a[0] - a[2], b[0] - b[1]);
            Console.ReadLine();
        }
    }
}
