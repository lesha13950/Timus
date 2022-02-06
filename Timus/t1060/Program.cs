using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1060
{
    class Program
    {
        static ushort[] MoveMatrix = new ushort[3] { 0b010, 0b111, 0b010 };
        static ushort[] Positions = new ushort[ushort.MaxValue];
        static ushort MakeMove(ushort p, ushort x, ushort y)
        {
            ushort mask = 0;
            int i;
            for (i = -1; i <= 1; i++)
            {
                ushort t = (ushort)(y + i);
                if (t >= 1 && t <= 4)
                {
                    ushort tm = MoveMatrix[i + 1];
                    int shift = 3 - x;
                    if (shift >= 0) tm <<= shift; else tm >>= 1;
                    tm &= 0xf;
                    mask |= (ushort)(tm << (4 - t) * 4);
                }
            }

            return (ushort)(p ^ mask);
        }
        static void Main(string[] args)
        {
            ushort StartPosition = 0;
            List<ushort> NewPositions = new List<ushort>(), l = new List<ushort>(); ;
            ushort moves = 1;
            bool SolutionFound = false;

            for (int i = 0; i < 4; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    if (s[j] == 'b') StartPosition |= 1;
                    if (i != 3 || j != 3) StartPosition <<= 1;
                }
            }

            if (StartPosition == 0 || StartPosition == ushort.MaxValue)
            {
                SolutionFound = true;
            }
            else
            {
                Positions[StartPosition] = moves;
                NewPositions.Add(StartPosition);
            }

            while (!SolutionFound)
            {
                if (NewPositions.Count == 0) break;

                moves++;
                l.Clear();
                foreach (ushort p in NewPositions) {
                    for (ushort x = 1; x <= 4 && !SolutionFound; x++)
                    {
                        for (ushort y = 1; y <= 4 && !SolutionFound; y++)
                        {
                            ushort np = MakeMove(p, x, y);
                            if (np == 0 || np == ushort.MaxValue)
                            {
                                SolutionFound = true;
                            }
                            else
                            {
                                if (Positions[np] == 0)
                                {
                                    Positions[np] = moves;
                                    l.Add(np);
                                }
                            }
                        }
                    }
                    if (SolutionFound) break;
                }
                if (!SolutionFound)
                {
                    NewPositions.Clear();
                    foreach (ushort el in l) NewPositions.Add(el);
                }
            }

            if (SolutionFound) Console.WriteLine(moves - 1); else Console.WriteLine("Impossible");
            Console.ReadLine();
        }
    }
}
