using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1029
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            ulong m = ulong.Parse(t[0]), n = ulong.Parse(t[1]);
            ulong[,] c = new ulong[m + 1, n + 1];
            (ulong price, ulong next)[,] p = new (ulong, ulong)[m + 1, n + 1];
            ulong min;
            ulong i, j;
            for (i = 0; i < m; i++)
            {
                t = Console.ReadLine().Split(' ');
                for (j = 0; j < n; j++) c[i + 1, j + 1] = ulong.Parse(t[j]);
            }

            for (j = 1; j <= n; j++)
            {
                p[m, j].price = c[m, j];
                p[m, j].next = 0;
            }

            for (i = m - 1; i >= 1; i--)
            {
                // first pass
                for (j = 1; j <= n; j++)
                {
                    p[i, j].price = c[i, j] + p[i + 1, j].price;
                    p[i, j].next = j;
                }

                // second pass - from left to right
                for (j = 1; j <= n; j++)
                {
                    if (j == 1)
                    {
                        if (j + 1 <= n)
                        {
                            min = c[i, j] + p[i, j + 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j + 1;
                            }
                        }
                    }
                    else if (j == n)
                    {
                        if (j - 1 >= 1)
                        {
                            min = c[i, j] + p[i, j - 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j - 1;
                            }
                        }
                    }
                    else
                    {
                        if (j + 1 <= n)
                        {
                            min = c[i, j] + p[i, j + 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j + 1;
                            }
                        }
                        if (j - 1 >= 1)
                        {
                            min = c[i, j] + p[i, j - 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j - 1;
                            }
                        }
                    }
                }

                // third pass - from right to left
                for (j = n; j >= 1; j--)
                {
                    if (j == 1)
                    {
                        if (j + 1 <= n)
                        {
                            min = c[i, j] + p[i, j + 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j + 1;
                            }
                        }
                    }
                    else if (j == n)
                    {
                        if (j - 1 >= 1)
                        {
                            min = c[i, j] + p[i, j - 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j - 1;
                            }
                        }
                    }
                    else
                    {
                        if (j + 1 <= n)
                        {
                            min = c[i, j] + p[i, j + 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j + 1;
                            }
                        }
                        if (j - 1 >= 1)
                        {
                            min = c[i, j] + p[i, j - 1].price;
                            if (min < p[i, j].price)
                            {
                                p[i, j].price = min;
                                p[i, j].next = j - 1;
                            }
                        }
                    }
                }
            }

            // search minimal price
            min = 1;
            for (j = 2; j <= n; j++)
                if (p[1, j].price < p[1, min].price) min = j;
            // restore cabinet sequence
            string seq = "";
            i = 1;
            j = min;
            while (j != 0)
            {
                ulong prev = j;
                seq += j.ToString() + " ";
                j = p[i, j].next;
                if (j == prev) i++;
            }
            Console.WriteLine(seq.Trim());
            Console.ReadLine();
        }
    }
}
