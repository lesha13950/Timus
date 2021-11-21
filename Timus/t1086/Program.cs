using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1086
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine().Trim());
            ulong[] primes = new ulong[15001];
            int N = 0;
            primes[++N] = 2;
            primes[++N] = 3;
            string result = "";

            for (int i = 0; i < k; i++)
            {
                int n = int.Parse(Console.ReadLine().Trim());
                
                if (n > N)
                {
                    ulong p = primes[N] + 2;
                    while (n != N)
                    {
                        bool flag = true;
                        int j = 1;
                        while (flag && (primes[j] * primes[j] <= p))
                        {
                            if (p % primes[j] == 0) flag = false;
                            j++;
                        }
                        if (flag) primes[++N] = p;
                        p += 2;
                    }
                }
                result += primes[n].ToString() + "\n";
            }
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
