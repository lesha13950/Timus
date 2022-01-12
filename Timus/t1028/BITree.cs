using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1028
{
    class BITree
    {

        private int[] b;

        public BITree(int N)
        {
            b = new int[N + 1]; // b[0] is dummy
        }

        public void Update(int x, int val)
        {
            int index = x + 1;

            while (index <= b.Length - 1)
            {
                b[index] += val;
                index += index & (-index);
            }
        }

        public int GetSum(int x)
        {
            int sum = 0;
            int index = x + 1;

            while (index > 0)
            {
                sum += b[index];
                index -= index & (-index);
            }
            return sum; 
        }
    }
}
