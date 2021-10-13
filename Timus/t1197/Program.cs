using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1197
{
    
    class Program
    {
        static int moves(string pos)
        {
            int v = pos[0] - 96, h = pos[1] - 48;
            int m = 0;
            
            //Check move up
            if (h + 2 < 9)
            {
                if (v - 1 > 0) m++;
                if (v + 1 < 9) m++;
            }
            //Check move down
            if (h - 2 > 0)
            {
                if (v - 1 > 0) m++;
                if (v + 1 < 9) m++;
            }
            //Check move right
            if (v + 2 < 9)
            {
                if (h - 1 > 0) m++;
                if (h + 1 < 9) m++;
            }
            //Check move left
            if (v - 2 > 0)
            {
                if (h - 1 > 0) m++;
                if (h + 1 < 9) m++;
            }
            return m;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            string[] pos = new string[64];
            int i;

            for (i = 0; i < N; i++)
            {
                pos[i] = Console.ReadLine().Trim();
            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine(moves(pos[i]));
            }

            Console.ReadLine();
        }
    }
}
