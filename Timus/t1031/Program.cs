using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1031
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int l1 = int.Parse(t[0]), l2 = int.Parse(t[1]), l3 = int.Parse(t[2]);
            int c1 = int.Parse(t[3]), c2 = int.Parse(t[4]), c3 = int.Parse(t[5]);
            int n = int.Parse(Console.ReadLine());
            int[] st = new int[n];
            t = Console.ReadLine().Trim().Split(' ');
            int st1 = int.Parse(t[0]) - 1, st2 = int.Parse(t[1]) - 1;
            if (st1 > st2)
            {
                int tmp = st1;
                st1 = st2;
                st2 = tmp;
            }
            int i;
            for (i = 1; i < n; i++) st[i] = int.Parse(Console.ReadLine());
            int[] C = new int[st2 - st1 + 1];

            int nl1, nl2, nl3;
            nl1 = nl2 = nl3 = st2;
            for (i = st2 - 1; i >= st1; i--)
            {
                int km = st[i];
                int j = nl1;
                while (km + l1 < st[j]) j--;
                if (j != i)
                {
                    nl1 = j;
                    C[st2 - i] = C[st2 - nl1] + c1;
                }
                if (km + l1 < st[st2])
                {
                    j = nl2;
                    while (km + l2 < st[j]) j--;
                    if (j != i)
                    {
                        nl2 = j;
                        if (C[st2 - i] == 0 || C[st2 - nl2] + c2 < C[st2 - i]) C[st2 - i] = C[st2 - nl2] + c2;
                    }
                }
                if (km + l2 < st[st2])
                {
                    j = nl3;
                    while (km + l3 < st[j]) j--;
                    nl3 = j;
                    if (C[st2 - i] == 0 || C[st2 - nl3] + c3 < C[st2 - i]) C[st2 - i] = C[st2 - nl3] + c3;
                }
            }
            Console.WriteLine(C[st2 - st1]);
            Console.ReadLine();
        }
    }
}
