using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.DataStructure.Queues
{
    public class QueueLinkedList
    {
        public Nodes Head = null;
        public Nodes Tail = null;

        public bool IsEmpty()
        {
            return Head==null &&Tail==null;
        }
        public void Enqueue(int data)
        {
            Nodes nodes = new Nodes(data);
            if (Tail == null)
            {
                Tail= Head= nodes;
                return;
            }
            Tail.Next = nodes;
            Tail=nodes;
        }
        public void Add(Nodes root)
        {
            Nodes nodes = root;
            if (Tail == null)
            {
                Tail = Head = nodes;
                return;
            }
            Tail.Next = nodes;
            Tail = nodes;
        }
        public int Remove()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int top = Head.data;
            if (Head == Tail)
            {
                Tail = null;
            }
            Head=Head.Next;
            return top;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return Head.data;
        }

    }
}
