using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1081
{
    class Program
    {
        static int[] L;
        static string getStr(int n, int k)
        {
            string s = "";
            if (n == 1)
            {
                if (k == 1) s = "0";
                if (k == 2) s = "1";
            }
            else if (n == 2)
            {
                if (k == 1) s = "00";
                if (k == 2) s = "01";
                if (k == 3) s = "10";
            }
            else
            {
                if (k <= L[n - 1]) s = "0" + getStr(n - 1, k);
                else s = "10" + getStr(n - 2, k - L[n - 1]);
            }
            return s;
        }
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(t[0]), K = int.Parse(t[1]);
            L = new int[44];
            L[1] = 2;
            L[2] = 3;
            int i;
            for (i = 3; i <= N; i++) L[i] = L[i - 1] + L[i - 2];

            if (K > L[N])
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(getStr(N, K));
            }
            Console.ReadLine();
        }
    }
}
