using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1545
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            string[] gliph = new string[N];
            char c;
            int i;

            for (i = 0; i < N; i++) gliph[i] = Console.ReadLine().Trim();
            c = Console.ReadLine().Trim()[0];

            Array.Sort(gliph);

            for (i = 0; i < N; i++)
                if (gliph[i][0] == c) Console.WriteLine(gliph[i]);

            Console.ReadLine();
        }
    }
}
