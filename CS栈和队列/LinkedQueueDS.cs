using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    class LinkedQueueDS<T>:IQueue<T>
    {
        private Node<T> head,reer;
        private int count;

        public LinkedQueueDS()
        {
            head = reer = null;
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            head = reer = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (reer == null)
            {
                head = reer = newNode;
                count++;
            }
            else if(reer==head)
            {
                reer.Next = newNode;
                reer = newNode;
                count++;
            }
        }

        public T Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("empty");
                return default(T);
            }
            else if(head == reer)
            {
                T temp = head.Data;
                head = reer = null;
                count--;
                return temp;
            }
            else
            {
                T temp = head.Data;
                head = head.Next;
                count--;
                return temp;
            }
        }

        public T Peek()
        {
            if (head != null)
            {
                return head.Data;
            }
            Console.WriteLine("empty");
            return default(T);
        }
    }
}
