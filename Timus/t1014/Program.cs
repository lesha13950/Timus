using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            string q = "";

            if (N == 0) q = "10";
            else if (N == 1) q = "1";
            else
            {
                for (int i = 9; i >= 2; i--)
                {
                    while (N % i == 0)
                    {
                        N /= i;
                        q = i + q;
                    }
                }
                if (N != 1) q = "-1";
            }
            
            Console.WriteLine(q);
            Console.ReadLine();
        }
    }
}
