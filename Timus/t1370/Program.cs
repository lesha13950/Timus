using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1370
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(t[0]), M = int.Parse(t[1]);
            int[] A = new int[N];
            int i;
            for (i = 0; i < N; i++) A[i] = int.Parse(Console.ReadLine().Trim());
            int start = M % N;
            for (i = 0; i < 10; i++) Console.Write(A[(start + i) % N]);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
