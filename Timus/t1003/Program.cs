using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1003
{
    class Program
    {
        static List<int> left = new List<int>(); // List of left borders of intervals
        static Dictionary<int, int> right = new Dictionary<int, int>(); // List of right borders of intervals
        static Dictionary<int, bool> odd = new Dictionary<int, bool>(); // Odd of the interval with left border == l

        static bool AddInterval(int l, int r, bool o)
        {
            bool res = false;
            if (!left.Contains(l))
            {
                left.Add(l);
                right[l] = r;
                odd[l] = o;
                res = true;
            }
            else
            {
                if (right[l] == r) res = (odd[l] == o);
                else if (right[l] < r) res = AddInterval(right[l] + 1, r, odd[l] ^ o);
                else res = AddInterval(r + 1, right[l], odd[l] ^ o);
            }
            return res;
        }

        static void Main(string[] args)
        {
            List<int> res = new List<int>();
            while (true)
            {
                string s = Console.ReadLine().Trim();
                if (s == "-1") break;

                left.Clear();
                right.Clear();
                odd.Clear();
                int n = int.Parse(s);
                int m = int.Parse(Console.ReadLine());
                bool ok = true; // Flag; false if incompatible answer occured; needed to skip the rest of the questions
                int c = 0; // Count of compatible answers
                for (int i = 0; i < m; i++)
                {
                    string[] t = Console.ReadLine().Trim().Split(' ');
                    if (ok)
                    {
                        int l = int.Parse(t[0]), r = int.Parse(t[1]);
                        bool o = ("odd" == t[2]);
                        if (l < 1 || r > n) ok = false;
                        else
                            if (ok = AddInterval(l, r, o)) c++;
                    }
                }
                res.Add(c);
            }

            foreach (int v in res) Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
