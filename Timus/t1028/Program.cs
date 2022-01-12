using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1028
{
    class Program
    {
        public const int MAX = 32000;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] levels = new int[N];
            int i;
            BITree B = new BITree(MAX + 1);

            for (i = 0; i < N; i++)
            {
                string[] t = Console.ReadLine().Trim().Split(' ');
                int x = int.Parse(t[0]);
                levels[B.GetSum(x)]++;
                B.Update(x, 1);
                if (i % 1000 == 0) GC.Collect();
            }

            for (i = 0; i < N; i++) Console.WriteLine(levels[i]);
            Console.ReadLine();
        }
    }
}
