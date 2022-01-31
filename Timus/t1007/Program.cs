using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1007
{
    class Program
    {
        
        static string RepairPacket(string p, int n)
        {
            int n1 = n + 1;
            int l = p.Length;
            string rp = ""; // Repaired packet
            int sum = 0;
            int i;

            for (i = 0; i < l; i++) sum += (p[i] == '1') ? (i + 1): 0;
            sum %= n1;

            if (l == n)
            {
                if (sum == 0) rp = p;
                else rp = p.Substring(0, sum - 1) + 0 + p.Substring(sum);
            }
            else if (l < n)
            {
                i = l;
                while (i >= 0)
                {
                    if (sum % n1 == 0)
                    {
                        rp = p.Substring(0, i) + "0" + p.Substring(i);
                        i = -1;
                    }
                    else if ((sum + i + 1) % n1 == 0)
                    {
                        rp = p.Substring(0, i) + "1" + p.Substring(i);
                        i = -1;
                    }
                    else if (p[i - 1] == '1') sum++;
                    i--;
                }
            }
            else
            {
                i = l - 1;
                while (i >= 0)
                {
                    if (sum % n1 == 0)
                    {
                        rp = p.Substring(0, i) + p.Substring(i + 1);
                        i = -1;
                    }
                    else
                    {
                        if (p[i] == '1')
                        {
                            if (((sum - i - 1) % n1) == 0)
                            {
                                rp = p.Substring(0, i) + p.Substring(i + 1);
                                i = -1;
                            }
                            else sum--;
                        }
                        i--;
                    }
                }
            }

            return rp;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s;
            List<string> output = new List<string>();
            while ((s = Console.ReadLine()) != null)
            {
                s = s.Trim();
                if (s == "") continue;
                output.Add(RepairPacket(s, n));
            }
            foreach (string v in output) Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
