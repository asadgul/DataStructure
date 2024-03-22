using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.DataStructure.StackData_Structure
{
    public class StackArrayList
    {
        List<int> storestack=new List<int>();
        public bool IsEmpty()
        {
            return storestack.Count == 0;
        }
        public void Push(int data)
        {
            storestack.Add(data);
        }
        public int Peek() {
            if (IsEmpty())
            {
                return -1;
            }
            return storestack[storestack.Count - 1];
        }
        public int Pop()
        {
            if (IsEmpty()) {return -1; }
            int top = storestack[storestack.Count - 1];
            storestack.Remove(top);
            return top;
        }
        public static void StackArrayListImplementation()
        {
            StackArrayList stackArrayList = new StackArrayList();
            stackArrayList.Push(1);
            stackArrayList.Push(2);
            stackArrayList.Push(3);
            stackArrayList.Push(4);
            while (!stackArrayList.IsEmpty())
            {
                Console.WriteLine(stackArrayList.Peek());
                stackArrayList.Pop();
            }
        }
        public static void PushElementsAtBotton(int data, StackArrayList s)
        {
            if (s.IsEmpty())
            {
                s.Push(data);
                return;
            }
            int top = s.Pop();
            PushElementsAtBotton(data, s);
            s.Push(top);
        }
        public static void ReverseStack(StackArrayList s)
        {
            if (s.IsEmpty())
            {
                return;
            }
            int top = s.Pop();
            ReverseStack(s);
            PushElementsAtBotton(top, s);
        }

    }
}
