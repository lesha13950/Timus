using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1226
{
    class Program
    {
        static string reverse(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--) rev += s[i];
            return rev;
        }
        static string crypt(string s)
        {
            string secret = "";
            string word = "";
            int i = 0;

            while (i < s.Length)
            {
                while (i < s.Length && !Char.IsLetter(s[i]))
                {
                    secret += s[i];
                    i++;
                }

                word = "";
                while (i < s.Length && Char.IsLetter(s[i]))
                {
                    word += s[i];
                    i++;
                }
                secret += reverse(word);
            }
            return secret;
        }

        static void Main(string[] args)
        {
            string text = "", secret = "", s = "";

            while ((s = Console.ReadLine()) != null) text += s + "\n";
            secret = crypt(text);

            Console.Write(secret);
            Console.ReadLine();
        }
    }
}
