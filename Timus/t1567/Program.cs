using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1567
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine().Trim();
            int[] price = new int[256];
            int sum = 0;

            price['a'] = price['d'] = price['g'] = price['j'] = price['m'] = price['p'] = price['s'] = price['v'] = price['y'] = price['.'] = price[' '] = 1;
            price['b'] = price['e'] = price['h'] = price['k'] = price['n'] = price['q'] = price['t'] = price['w'] = price['z'] = price[','] = 2;
            price['c'] = price['f'] = price['i'] = price['l'] = price['o'] = price['r'] = price['u'] = price['x'] = price['!'] = 3;

            for (int i = 0; i < message.Length; i++)
                sum += price[message[i]];

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
