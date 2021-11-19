using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1712
{
    class Program
    {
        static string ApplyGrid(string[] grid, string[] secret)
        {
            string result = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i][j] == 'X') result += secret[i][j];
                }
            }

            return result;
        }

        static void RotateGrid(ref string[] grid)
        {
            string[] result = new string[4] { "", "", "", "" };

            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 4; i++)
                    result[j] += grid[3 - i][j];
            grid = result;
        }

        static void Main(string[] args)
        {
            string[] grid = new string[4], secret = new string[4];
            string password = "";
            int i;

            for (i = 0; i < 4; i++) grid[i] = Console.ReadLine().Trim();
            for (i = 0; i < 4; i++) secret[i] = Console.ReadLine().Trim();

            for (i = 0; i < 4; i++)
            {
                password += ApplyGrid(grid, secret);
                RotateGrid(ref grid);
            }
            Console.WriteLine(password);
            Console.ReadLine();
        }
    }
}
