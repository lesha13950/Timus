using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1496
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            string[] commands = new string[N];
            string spamer = "";
            int i;

            for (i = 0; i < N; i++) commands[i] = Console.ReadLine().Trim();
            Array.Sort(commands);

            for (i = 1; i < N; i++)
            {
                if (commands[i] != spamer)
                {
                    if (commands[i] == commands[i - 1])
                    {
                        spamer = commands[i];
                        Console.WriteLine(spamer);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
