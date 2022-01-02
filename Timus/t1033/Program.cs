using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1033
{
    class Program
    {
        static void trav(char[,] l, int N, int i, int j)
        {
            if (i == 0 || j == 0 || i > N || j > N) return;
            if (l[i, j] == '+') return;
            l[i, j] = '+';
            if (l[i - 1, j] == '.') trav(l, N, i - 1, j);
            if (l[i + 1, j] == '.') trav(l, N, i + 1, j);
            if (l[i, j - 1] == '.') trav(l, N, i, j - 1);
            if (l[i, j + 1] == '.') trav(l, N, i, j + 1);
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int extN = N + 2;
            int count = 0;
            int i, j;
            char[,] lab = new char[extN, extN];
            // Maze borders initialization
            lab[0, 0] = lab[0, 1] = lab[1, 0] = '.';
            lab[extN - 1, extN - 2] = lab[extN - 1, extN - 1] = lab[extN - 2, extN - 1] = '.';
            for (i = extN - 1; i >= 2; i--)
            {
                lab[0, i] = lab[i - 2, extN - 1] = '#';
                lab[i, 0] = lab[extN - 1, i - 2] = '#';
            }

            // Maze filling
            for (i = 1; i <= N; i++)
            {
                string s = Console.ReadLine();
                for (j = 1; j <= N; j++) lab[i, j] = s[j - 1];
            }

            // Maze traversal starting from (1, 1)
            trav(lab, N, 1, 1);
            // Check stupid statement: there is no way from (1, 1) to (N, N)
            trav(lab, N, N, N);

            // Maze scanning and counting of walls
            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    if (lab[i, j] == '+')
                    {
                        if (lab[i - 1, j] == '#') count++;
                        if (lab[i + 1, j] == '#') count++;
                        if (lab[i, j - 1] == '#') count++;
                        if (lab[i, j + 1] == '#') count++;
                    }
                }
            }

            Console.WriteLine(count * 9);
            for (i = 0; i < extN; i++)
            {
                for (j = 0; j < extN; j++) Console.Write(lab[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
