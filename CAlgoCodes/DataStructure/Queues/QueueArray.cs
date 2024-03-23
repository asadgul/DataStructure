using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.DataStructure.Queues
{
    public class QueueArray
    {
        public int[] arr;
        public int size;
        public int Rear = -1;
        public QueueArray(int n)
        {
            size = n;
            arr = new int[n];
        }
        public bool IsEmpty()
        {
            return Rear==-1;
        }
        public void EnQueue(int data)
        {
            if (Rear == arr.Length - 1)
            {
                return;
            }
            Rear++;
            arr[Rear] = data;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return arr[0];
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int front = arr[0];
            for(int i = 0; i < Rear; i++)
            {
                arr[i] = arr[i+1];
            }
            Rear--;
            return front;
        }

    }
}
