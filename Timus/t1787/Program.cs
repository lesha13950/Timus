using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1787
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int k = int.Parse(t[0]), n = int.Parse(t[1]);
            int i;
            int a;
            int count = 0;
            t = Console.ReadLine().Trim().Split(' ');
            for (i = 0; i < n; i++)
            {
                a = int.Parse(t[i]);
                count = Math.Max(0, count + a - k);
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
