using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1297
{
    class Program
    {
        static bool isPalindrome(string s)
        {
            bool res = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return res;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            string p = "";
            int max = p.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length - i < max) break;
                for (int j = s.Length - 1; j >= i; j--)
                {
                    if (s[j] == s[i])
                    {
                        string t = s.Substring(i, j - i + 1);
                        if (isPalindrome(t))
                        {
                            if (t.Length > max)
                            {
                                p = t;
                                max = p.Length;
                            }
                        }
                    }
                } 
            }

            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
