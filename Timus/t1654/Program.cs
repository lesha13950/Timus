using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1654
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> s = new List<char>(Console.ReadLine().Trim().ToCharArray());
            int i, j;

            i = 0;
            while (i < s.Count - 1)
            {
                if (s[i] == s[i + 1])
                {
                    j = 2;
                    while (i + j < s.Count && s[i] == s[i + j]) j++;
                    if (j % 2 == 1)
                        s.RemoveRange(i, j - 1);
                    else
                        s.RemoveRange(i, j);

                    if (j % 2 == 0)
                    {
                        while (i - 1 >= 0 && i < s.Count && s[i] == s[i - 1])
                        {
                            i--;
                            s.RemoveRange(i, 2);
                        }
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(s.ToArray());
            Console.ReadLine();
        }
    }
}
