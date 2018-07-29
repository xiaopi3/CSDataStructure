using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    class LinkedDS<T> : IList<T>
    {
        private Node<T> head;
        public LinkedDS()
        {
            head = null;
        }
        public T this[int index] => GetEle(index);

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> temp = head;
            
            while (true)
            {
                if (temp.Next == null)
                {
                    temp.Next = newNode;
                    break;
                }
                temp = temp.Next;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public T Delete(int index)
        {
            if (head == null)
            {
                Console.WriteLine("index out of boundes!");
                return default(T);
            }
            Node<T> temp = head;
            Node<T> currentNode;
            Node<T> preNode;
            if (index == 0)
            {
                currentNode = temp;
                head = temp.Next;
            }
            else
            {
                for(int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                preNode = temp;
                currentNode = temp.Next;

                preNode.Next = currentNode.Next;
            }
            return currentNode.Data;
        }

        public T GetEle(int index)
        {
            if (head == null)
            {
                Console.WriteLine("index out of boundes!");
                return default(T);
            }
            Node<T> temp = head;
            for(int i = 1; i <= index; i++)
            {
                if (temp.Next == null)
                {
                    Console.WriteLine("index out of boundes!");
                    return default(T);
                }
                temp = temp.Next;
            }
            return temp.Data;            
        }

        public int GetLength()
        {
            if (head == null) return 0;
            int count = 1;
            Node<T> temp = head;
            while (true)
            {
                if (temp.Next == null)
                    break;
                count++;
                temp = temp.Next;
            }
            return count; 
        }

        public void Insert(T item, int index)
        {
            if (head == null)
            {
                Console.WriteLine("index out of boundes!");
                return;
            }
            Node<T> temp = head;
            Node<T> currentNode;
            Node<T> preNode;
            Node<T> newNode = new Node<T>(item);
            if (index == 0)
            {               
                
                newNode.Next = temp;
                head = newNode;
            }
            else
            {
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                preNode = temp;
                currentNode = temp.Next;

                preNode.Next = newNode;
                newNode.Next = currentNode;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Locate(T item)
        {
            int index = 0;
            Node<T> temp = head;
            while (true)
            {
                if (temp != null)
                {
                    if (temp.Data.Equals(item))
                    {
                        return index;
                    }
                    index++;
                    temp = temp.Next;
                }
                else
                {
                    Console.WriteLine("no such element!");
                    return -1;
                }
            }
        }
    }
}
