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
            Stack<char> s = new Stack<char>();
            string str = Console.ReadLine().Trim();
            char[] c;

            for (int i = 0; i < str.Length; i++)
            {
                if (s.Count > 0 && str[i] == s.Peek()) s.Pop();
                else s.Push(str[i]);
            }

            c = s.ToArray();
            Array.Reverse(c);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
