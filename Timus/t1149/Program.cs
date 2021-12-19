using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string[] A = new string[n + 1];
            string Sn = "";
            int i, j;

            // A[n] initialization
            for (i = 1; i <= n; i++)
            {
                A[i] = "sin(1";
                for (j = 2; j <= i; j++)
                {
                    if (j % 2 == 0) A[i] += "-sin(";
                    else A[i] += "+sin(";
                    A[i] += j.ToString();
                }
                for (j = 0; j < i; j++) A[i] += ")";
            }
            //Sn calculating
            for (i = 1; i < n; i++) Sn += "(";
            for (i = 1; i <= n; i++)
            {
                Sn += A[i] + "+" + (n - i + 1).ToString();
                if (i < n) Sn += ")";
            }

            Console.WriteLine(Sn);
            Console.ReadLine();
        }
    }
}
