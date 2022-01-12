using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1028
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] levels = new int[N];
            string[] t;
            int i;
            Tree T = new Tree();
            for (i = 0; i < N; i++)
            {
                if (i % 1000 == 0) GC.Collect();
                t = Console.ReadLine().Trim().Split(' ');
                levels[T.Search(int.Parse(t[0]))]++;
            }

            for (i = 0; i < N; i++) Console.WriteLine(levels[i]);
            Console.ReadLine();
        }
    }
}
