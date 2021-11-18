using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1404
{
    static class StringHelper
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string secret = Console.ReadLine().Trim();
            string pass = "";

            for (int i = secret.Length - 1; i >= 0; i--)
            {
                int diff;
                if (i != 0)
                {
                    diff = secret[i] - secret[i - 1];
                }
                else
                {
                    diff = secret[i] - 5 - (int)'a';
                }
                if (diff < 0) diff += 26;
                pass += (char)(diff + (int)'a');
            }

            Console.WriteLine(StringHelper.ReverseString(pass));
            Console.ReadLine();
        }
    }
}
