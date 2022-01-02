using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1049
{
    class Program
    {
        static int[] delimiters = new int[10000];
        static void factorization(int a)
        {
            int m = 2;
            int ta = a;
            while (ta > 1 && m * m <= a)
            {
                while ((ta % m == 0) && ta > 1)
                {
                    delimiters[m]++;
                    ta /= m;
                }
                m++;
            }
            if (ta > 1) delimiters[ta]++;
        }
        static void Main(string[] args)
        {
            int count = 1;
            int i;
            for (i = 0; i < 10; i++)
            {
                factorization(int.Parse(Console.ReadLine()));
            }
            for (i = 0; i < 10000; i++)
            {
                if (delimiters[i] > 0)
                {
                    count *= delimiters[i] + 1;
                    count %= 10;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
