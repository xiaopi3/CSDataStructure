using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列.练习
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
            }
            else
            {
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
        }

        public void Clear()
        {
            head = null;
        }

        public T Delete(int index)
        {
            T tempData;
            if (index == 0)
            {
                tempData = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;
                for(int i = 1; i <= index-1; i++)
                {
                    temp = temp.Next;
                }
                tempData = temp.Next.Data;;
                temp.Next = temp.Next.Next;
            }
            return tempData;
        }

        public T GetEle(int index)
        {
            if (head == null) { Console.WriteLine("index out of bounds"); return default(T); }
            Node<T> temp = head;
            for(int i = 0; i < index; i++)
            {
                temp = temp.Next;
                if (temp == null)
                {
                    Console.WriteLine("index out of bounds"); return default(T);
                }
            }
            return temp.Data;
        }

        public int GetLength()
        {
            int count = 1;
            if (head == null) {return 0; }
            Node<T> temp = head;
            while (true)
            {
                if (temp.Next == null) return count;
                temp = temp.Next;
                count++;
            }
        }

        public void Insert(T item, int index)
        {
            Node<T> temp = head;
            Node<T> newNode = new Node<T>(item);
            if (head == null)
            {
                Console.WriteLine("index out of bounds");
                return;
            }
            else
            {
                if (index == 0)
                {
                    newNode.Next = head;
                    head = newNode;
                    return;
                }
                else
                {
                    for (int i = 1; i <= index-1; i++)
                    {
                        if (temp.Next == null)
                        {
                            Console.WriteLine("index out of bounds");
                            return;
                        }
                        else
                        {
                            temp = temp.Next;
                        }
                    }
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                } 
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Locate(T item)
        {
            Node<T> temp = head;
            int count = 0;
            while (true)
            {
                if (temp == null)
                {
                    return -1;
                }
                else
                {
                    if (temp.Data.Equals(item))
                    {
                        return count;
                    }
                    else
                    {
                        count++;
                        temp = temp.Next;
                    }
                }
            }
        }
    }
}
