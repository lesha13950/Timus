using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1028
{
    class TreeNode
    {
        public int Key { get; set; }
        public int Rank { get; set; } = 1;
        public int NL { get; set; } = 0;
        public int NR { get; set; } = 0;
        public int Bal { get; set; } = 0;
        public TreeNode Left { get; set; } = null;
        public TreeNode Right { get; set; } = null;
        public TreeNode P { get; set; }

        public TreeNode(int key, TreeNode parent = null)
        {
            Key = key;
            P = parent;
        }

    }
}
