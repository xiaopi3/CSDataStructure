using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    class LinekedStackDS<T>:IStack<T>
    {
        private Node<T> head;
        private int count;
        public LinekedStackDS()
        {
            head = null;
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (count == 0)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            count++;
        }

        public T Pop()
        {
            if (count == 0)
            {
                Console.WriteLine("empty");
                return default(T);
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
            if (count == 0)
            {
                Console.WriteLine("empty");
                return default(T);
            }
            else
            {
                return head.Data;
            }
        }
    }
}
