using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1087
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]), m = int.Parse(t[1]);
            int i, j;
            t = Console.ReadLine().Split(' ');
            int[] k = new int[m];
            for (i = 0; i < m; i++) k[i] = int.Parse(t[i]);
            bool[] success = new bool[n + 1];

            success[0] = true;
            for (i = 1; i <= n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if ((i - k[j] > 0) && (!success[i - k[j]]))
                    {
                        success[i] = true;
                        break;
                    }
                }
            }

            Console.WriteLine(success[n] ? "1" : "2");
            Console.ReadLine();
        }
    }
}
