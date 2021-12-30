using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1563
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            Dictionary<string, bool> buticks = new Dictionary<string, bool>();
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                buticks[s] = true;
            }
            Console.WriteLine(N - buticks.Count);
            Console.ReadLine();
        }
    }
}
