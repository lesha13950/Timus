using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1581
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int n, c;
            int i;
            string[] t = Console.ReadLine().Trim().Split(' ');

            i = 0;
            while (i < N)
            {
                if (i != 0) Console.Write(' ');
                n = int.Parse(t[i]);
                c = 0;
                while (i < N && int.Parse(t[i]) == n)
                {
                    c++;
                    i++;
                }
                Console.Write("{0} {1}", c, n);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
