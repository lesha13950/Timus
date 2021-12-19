using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1131
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(tokens[0]), K = int.Parse(tokens[1]);
            int time = 0, count = 1, wires = 1;

            while (count < N)
            {
                if (wires == K)
                {
                    time += (N - count) / wires;
                    if ((N - count) % wires > 0) time++;
                    break;
                }
                count += wires;
                time++;
                wires *= 2;
                if (wires > K) wires = K;
            }

            Console.WriteLine(time);
            Console.ReadLine();
        }
    }
}
