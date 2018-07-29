using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    class ArrayQueueDS<T>:IQueue<T>
    {
        private T[] arr;
        private int count;
        private int reer;
        private int front;

        public ArrayQueueDS(int size){
            arr=new T[size];
            count=0;
            reer = front = -1;
        }
        public ArrayQueueDS() : this(10) { }

        public void Clear()
        {
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Enqueue(T item)
        {
            if (count < arr.Length)
            {
                if (reer == arr.Length - 1)
                {
                    reer = 0;
                }
                else
                {
                    reer++;
                }
                arr[reer] = item;
                count++;
            }
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("empty");
                return default(T);
            }
            else
            {
                if (front == arr.Length - 1)
                {
                    front = 0;
                }
                else
                {
                    front--;
                }
                return arr[front];
            }
        }

        public T Peek()
        {
            if (count == 0)
            {
                Console.WriteLine("empty");
                return default(T);
            }
            else
            {
                if (front == arr.Length - 1)
                {
                    return arr[0];
                }
                else
                {
                    return arr[front - 1];
                }
            }
        }

        public int Count
        {
            get { return count; }
        }
    }
}
