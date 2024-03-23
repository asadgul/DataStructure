using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.DataStructure.Queues
{
    public class CircularQueue
    {
        public int[] arr;
        public int front = -1, rear = -1;
        public int size;
        public CircularQueue(int size)
        {
            this.size = size;
            arr = new int[size];            
        }
        public bool IsFull()
        {
            return front == (rear + 1) % size;
        }
        public bool IsEmpty()
        {
            return rear ==-1&& front == -1;
        }
        public void EnQueue(int data)
        {
            if (IsFull())
            {
                return;
            }
            if (front == -1)
            {
                front = 0;
            }
            rear++;
            rear = (rear + 1) % size;
            arr[rear] = data;
        }
        public int DeQueue()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int result = arr[front];
            front = (front + 1) % size;
            return result;
        }
        public int Peek()
        {
            return arr[front];
        }
    }
}
