using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1021
{
    class Program
    {
        const int MAXN = 50000;
        const int HolyNumber = 10000;
        static void Main(string[] args)
        {
            int N1, N2;
            int[] list1 = new int[MAXN], list2 = new int[MAXN];
            int i;
            bool result = false;

            N1 = int.Parse(Console.ReadLine().Trim());
            for (i = 0; i < N1; i++) list1[i] = int.Parse(Console.ReadLine().Trim());
            N2 = int.Parse(Console.ReadLine().Trim());
            for (i = N2 - 1; i >= 0; i--) list2[i] = int.Parse(Console.ReadLine().Trim());

            i = 0;
            while (!result && i < N1)
            {
                int n = HolyNumber - list1[i];
                int l = 0, r = N2 - 1;
                while (!result && l <= r)
                {
                    int m = (l + r) / 2;
                    if (list2[m] == n) result = true;
                    else if (list2[m] > n) r = m - 1;
                    else l = m + 1;
                }
                i++;
            }

            if (result) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
