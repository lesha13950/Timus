using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1022
{
    class Program
    {
        const int MAXN = 100;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            string[] parentsOf = new string[MAXN + 1];
            int[] numOfParents = new int[MAXN + 1];
            string result = "";
            int t = N;
            int i, j;

            for (i = 1; i <= MAXN ; i++) {
                parentsOf[i] = " ";
                numOfParents[i] = 0;
            }

            for (i = 0; i < N; i++)
            {
                string[] childs = Console.ReadLine().Trim().Split(' ');

                for (j = 0; j < childs.Length - 1; j++)
                {
                    int child = int.Parse(childs[j]);
                    parentsOf[child] += (i + 1).ToString() + " ";
                    numOfParents[child]++;
                }
            }

            while (t > 0)
            {
                i = 1;
                while (numOfParents[i] != 0) i++;
                result += i.ToString() + " ";
                numOfParents[i] = -1;
                for (j = 1; j<= N; j++)
                {
                    if (parentsOf[j].IndexOf(" " + i.ToString() + " ") >= 0) numOfParents[j]--;
                }
                t--;
            }

            Console.WriteLine(result.Trim());
            Console.ReadLine();
        }
    }
}
