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
            int i, j;
            bool result = false;

            N1 = int.Parse(Console.ReadLine().Trim());
            for (i = 0; i < N1; i++) list1[i] = int.Parse(Console.ReadLine().Trim());
            N2 = int.Parse(Console.ReadLine().Trim());
            for (i = 0; i < N2; i++) list2[i] = int.Parse(Console.ReadLine().Trim());

            i = 0;
            while (!result && i < N1)
            {
                j = 0;
                while (!result && j < N2)
                {
                    if (list1[i] + list2[j] == HolyNumber) result = true;
                    j++;
                }
                i++;
            }

            if (result) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
