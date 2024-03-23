using CAlgoCodes.DataStructure;
using CAlgoCodes.DataStructure.Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.Binary_Trees
{
    public class BinaryTree
    {
        int index = -1;
        public  Nodes CreateTree(int[]nodes)
        {
            index++;
            if (nodes[index] == -1)
            {
                return null;
            }
            Nodes newnode = new Nodes(nodes[index]);
            newnode.Left = CreateTree(nodes);
            newnode.Right = CreateTree(nodes);
            return newnode;// That will return root node
        }
        public void Preorder(Nodes root)
        {
            if (root == null)
            {
                return; 
            }
            Console.WriteLine(root.data);
            Preorder(root.Left);
            Preorder(root.Right);
        }
        public void Inorder(Nodes root)
        {
            if (root == null)
            {
                return;
            }
            Inorder(root.Left);
            Console.WriteLine(root.data);
            Inorder(root.Right);
        }
        public void Postorder(Nodes root)
        {
            if (root == null)
            {
                return;
            }
            Postorder(root.Left);
            Postorder(root.Right);
            Console.WriteLine(root.data);
        }
        public int CountofNode(Nodes root)
        {
            if (root == null)
            {
                return 0;
            }
            int left=CountofNode(root.Left);
            int right=CountofNode(root.Right);
            return left + right+1;
        }
        //public void LevelOrderTraversal(Nodes root)
        //{
        //    QueueLinkedList queueLinkedList1 = new QueueLinkedList();
        //    queueLinkedList1.Add(root);
        //    queueLinkedList1.Add(null);
        //    while (!queueLinkedList1.IsEmpty())
        //    {
        //        Nodes current=queueLinkedList1.Remove();

        //    }
           

        //}
    }
}
