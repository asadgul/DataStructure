using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.DataStructure
{   
    public class StackLinkList
    {
        public Nodes Head;
        public bool IsEmpty()
        {
            return Head == null;
        }
        public void push(int data)
        {
            Nodes newnodes = new Nodes(data);
            if (Head == null)
            {
                Head = newnodes;
                return;
            }
            newnodes.Next = Head;
            Head = newnodes;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return Head.data;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int top= Head.data;
            Head=Head.Next; return top;
        }
        
        public static void PushElementsAtBotton(int data,StackLinkList s)
        {
            if (s.IsEmpty())
            {
                s.push(data);
                return;
            }
            int top=s.Pop();
            PushElementsAtBotton(data, s);
            s.push(top);
        }
        public static void ReverseStack(StackLinkList s)
        {
            if (s.IsEmpty())
            {
                return;
            }
            int top=s.Pop();
            ReverseStack(s);
            PushElementsAtBotton(top, s);
        }
       
    }
}
