using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1290
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int[] A = new int[N];
            int i;
            for (i = 0; i < N; i++) A[i] = int.Parse(Console.ReadLine().Trim());
            Array.Sort(A);
            Array.Reverse(A);
            for (i = 0; i < N; i++) Console.WriteLine(A[i]);
            Console.ReadLine();
        }
    }
}
