using CAlgoCodes.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.BST
{
    public class BinarySearchTree
    {
        public Nodes CreateBst(Nodes root,int value)
        {
            if (root == null)
            {
                root=new Nodes(value);
                return root;
            }
            if (root.data > value)
            {
             root.Left= CreateBst(root.Left, value);
            }
            else
            {
                root.Right= CreateBst(root.Right, value);
            }

            return root;
        }
        public void InOrderTraversal(Nodes root)
        {
            if (root == null)
            {
                return ;
            }
            InOrderTraversal(root.Left);
            Console.WriteLine(root.data);
            InOrderTraversal(root.Right);
        }
        public Boolean SearchNode(Nodes root,int key)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data > key)
            {
                return SearchNode(root.Left, key);
            }
            else if (root.data == key)
            {
                return true;
            }
            else
            {
                return SearchNode(root.Right, key);
            }
        }
        public Nodes DeleteNode(Nodes root,int value)
        {
            if (root.data > value)
            {
                root.Left=DeleteNode(root.Left, value);
            }
            else if (root.data < value)
            {
                root.Right = DeleteNode(root.Right, value);
            }
            else
            {
                if(root.Left==null && root.Right == null)
                {
                    return null;
                }
                else if (root.Left==null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }
                else
                {
                    Nodes rootd = IsSuccessor(root.Right);
                    root.data = rootd.data;
                    root.Right=DeleteNode(root.Right, rootd.data);
                }

            }
            return root;

        }
        public Nodes IsSuccessor(Nodes nodes)
        {
            while (nodes.Left != null)
            {
                nodes = nodes.Left;
            }
            return nodes;
        }

    }
}
