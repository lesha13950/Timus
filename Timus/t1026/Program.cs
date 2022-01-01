using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1026
{
    class Program
    {
        const int DBSIZE = 100000;
        const int MAXQUERY = 5000;
        static void Main(string[] args)
        {
            int N, K;
            int i;
            int[] db = new int[DBSIZE];
            int[] q = new int[100];

            // db initialization
            for (i = 0; i < DBSIZE; i++) db[i] = MAXQUERY + 1;

            N = int.Parse(Console.ReadLine().Trim());
            for (i = 0; i < N; i++) db[i] = int.Parse(Console.ReadLine().Trim());
            Array.Sort(db);
            Console.ReadLine(); // skip ###
            K = int.Parse(Console.ReadLine().Trim());
            for (i = 0; i < K; i++) q[i] = int.Parse(Console.ReadLine().Trim());
            for (i = 0; i < K; i++) Console.WriteLine(db[q[i] - 1]);
            Console.ReadLine();
        }
    }
}
