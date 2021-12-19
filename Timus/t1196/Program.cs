using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1196
{
    class Program
    {
        static bool contains(int[] list, int el)
        {
            bool found = false;
            int l = 0, r = list.Length - 1;
            while (!found && l <= r)
            {
                int m = (l + r) / 2;
                if (list[m] == el) found = true;
                else if (list[m] < el) l = m + 1;
                else r = m - 1;
            }
            return found;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine().Trim());
            int[] teacher_list = new int[N];
            int i;
            for (i = 0; i < N; i++) teacher_list[i] = int.Parse(Console.ReadLine().Trim());
            int M = int.Parse(Console.ReadLine().Trim());
            int correct = 0; ;

            for (i = 0; i < M; i++)
            {
                int student_year = int.Parse(Console.ReadLine().Trim());
                if (contains(teacher_list, student_year)) correct++;
            }

            Console.WriteLine(correct);
            Console.ReadLine();
        }
    }
}
