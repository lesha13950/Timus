using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1493
{
    class Program
    {
        static bool isLucky(string t)
        {
            return (t[0] + t[1] + t[2]) == (t[3] + t[4] + t[5]);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string next = "", prev = "";

            next = (n + 1).ToString("d6");
            prev = (n - 1).ToString("d6");
            if (isLucky(next) || isLucky(prev)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}
