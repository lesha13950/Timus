using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1573
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int B = int.Parse(t[0]), R = int.Parse(t[1]), Y = int.Parse(t[2]);
            int K = int.Parse(Console.ReadLine().Trim());
            int res = 1;
            for (int i = 0; i < K; i++)
            {
                char c = Console.ReadLine().Trim()[0];
                if (c == 'B') res *= B;
                else if (c == 'R') res *= R;
                else res *= Y;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
