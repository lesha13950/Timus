using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1022
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            string[] parentsOf = new string[N + 1];
            int[] numOfParents = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                string[] childs = Console.ReadLine().Trim().Split(' ');

                for (int j = 0; j < childs.Length - 1; j++)
                {
                    int child = int.Parse(childs[j]);
                    parentsOf[child] += (i + 1).ToString() + " ";
                    numOfParents[child]++;
                }
            }

            Console.ReadLine();
        }
    }
}
