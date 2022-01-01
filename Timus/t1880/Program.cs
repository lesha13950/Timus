using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1880
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[4000];
            List<int> l = new List<int>();
            string[] t;
            int i, j;

            n = int.Parse(Console.ReadLine().Trim());
            t = Console.ReadLine().Trim().Split(' ');
            for (i = 0; i < n; i++) l.Add(int.Parse(t[i]));

            for (i = 1; i < 3; i++)
            {
                Array.Clear(a, 0, 4000);
                n = int.Parse(Console.ReadLine().Trim());
                t = Console.ReadLine().Trim().Split(' ');
                for (j = 0; j < n; j++) a[j] = int.Parse(t[j]);
                j = 0;
                while (j < l.Count)
                {
                    if (!a.Contains(l[j])) l.RemoveAt(j);
                    else j++;
                }
            }
            Console.WriteLine(l.Count);
            Console.ReadLine();
        }
    }
}
