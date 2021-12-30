using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1723
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            int[] c = new int[256];
            int indmax = 0;
            int i;

            for (i = 0; i < s.Length; i++) c[s[i]]++;
            for (i = 1; i < 256; i++)
            {
                if (c[i] > c[indmax]) indmax = i;
            }
            Console.WriteLine((char)indmax);
            Console.ReadLine();
        }
    }
}
