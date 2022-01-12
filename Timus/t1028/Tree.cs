using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1028
{
    class Tree
    {
        public TreeNode Root { get; set; } = null;

        private void correctN(TreeNode p)
        {
            if (p == null) return;
            if (p.Left != null)
            {
                p.NL = p.Left.NL + p.Left.NR + p.Left.Rank;
            }
            else p.NL = 0;
            if (p.Right != null)
            {
                p.NR = p.Right.NL + p.Right.NR + p.Right.Rank;
            }
            else p.NR = 0;
        }

        private void balance(TreeNode cur)
        {
            bool h = true;
            TreeNode p, p1, p2;
            p = p1 = p2 = null;

            while (h)
            {
                p = cur.P;
                if (p == null) break;
                // The left subtree has grown
                if (cur == p.Left)
                {
                    if (p.Bal == 1)
                    {
                        p.Bal = 0;
                        h = false;
                    }
                    else if (p.Bal == 0) p.Bal = -1;
                    else
                    {
                        p1 = p.Left;
                        if (p1.Bal == -1) // LL
                        {
                            if (p1.Right != null) p1.Right.P = p;
                            p.Left = p1.Right;
                            p1.P = p.P;
                            if (p.P == null) Root = p1;
                            else
                            {
                                if (p.P.Left == p) p.P.Left = p1;
                                else p.P.Right = p1;
                            }
                            p1.Right = p;
                            p.P = p1;
                            p.Bal = p1.Bal = 0;
                        }
                        else // LR
                        {
                            p2 = p1.Right;
                            if (p2.Left != null) p2.Left.P = p1;
                            p1.Right = p2.Left;
                            p2.P = p;
                            p.Left = p2;
                            p2.Left = p1;
                            p1.P = p2;
                            p.Left = p2.Right;
                            p2.P = p.P;
                            if (p.P == null) Root = p2;
                            else
                            {
                                if (p.P.Left == p) p.P.Left = p2;
                                else p.P.Right = p2;
                            }
                            p2.Right = p;
                            p.P = p2;
                            if (p2.Bal == -1) p.Bal = 1; else p.Bal = 0;
                            if (p2.Bal == 1) p1.Bal = -1; else p1.Bal = 0;
                            p2.Bal = 0;
                        }
                        h = false;
                    }
                }
                // The right subtree has grown
                else
                {
                    if (p.Bal == -1)
                    {
                        p.Bal = 0;
                        h = false;
                    }
                    else if (p.Bal == 0) p.Bal = 1;
                    else
                    {
                        p1 = p.Right;
                        if (p1.Bal == 1) // RR
                        {
                            if (p1.Left != null) p1.Left.P = p;
                            p.Right = p1.Left;
                            p1.P = p.P;
                            if (p.P == null) Root = p1;
                            else
                            {
                                if (p.P.Left == p) p.P.Left = p1;
                                else p.P.Right = p1;
                            }
                            p1.Left = p;
                            p.P = p1;
                            p.Bal = p1.Bal = 0;
                        }
                        else //RL
                        {
                            p2 = p1.Left;
                            if (p2.Right != null) p2.Right.P = p1;
                            p1.Left = p2.Right;
                            p2.P = p;
                            p.Right = p2;
                            p2.Right = p1;
                            p1.P = p2;
                            p.Right = p2.Left;
                            p2.P = p.P;
                            if (p.P == null) Root = p2;
                            else
                            {
                                if (p.P.Left == p) p.P.Left = p2;
                                else p.P.Right = p2;
                            }
                            p2.Left = p;
                            p.P = p2;
                            if (p2.Bal == 1) p.Bal = -1; else p.Bal = 0;
                            if (p2.Bal == -1) p1.Bal = 1; else p1.Bal = 0;
                            p2.Bal = 0;
                        }
                        h = false;
                    }
                }
                if (h) cur = cur.P;
            }
            correctN(p);
            correctN(p1);
            correctN(p2);
        }
        public int Search(int x)
        {
            int level = 0;
            

            if (Root == null)
            {
                Root = new TreeNode(x);
            }
            else
            {
                TreeNode cur = Root, prev = null;
                while (cur != null)
                {
                    if (x == cur.Key)
                    {
                        level += cur.NL + cur.Rank;
                        cur.Rank++;
                        break;
                    }
                    else
                    {
                        prev = cur;
                        if (x < cur.Key)
                        {
                            cur.NL++;
                            cur = cur.Left;
                        }
                        else
                        {
                            level += cur.NL + cur.Rank;
                            cur.NR++;
                            cur = cur.Right;
                        }
                    }
                    
                }
                if (cur == null)
                {
                    cur = new TreeNode(x, prev);
                    if (x < prev.Key)
                    {
                        prev.Left = cur;
                    }
                    else
                    {
                        prev.Right = cur;
                    }
                    balance(cur);
                }
            }
            return level;
        }
    }
}
