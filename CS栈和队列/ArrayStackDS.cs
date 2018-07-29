using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    class ArrayStackDS<T>:IStack<T>
    {
        private T[] arr;
        private int point;

        public ArrayStackDS(int size)
        {
            arr = new T[size];
            point = -1;
        }
        public ArrayStackDS():this(10)
        {
            
        }
        public int Count
        {
            get { return point + 1; }
        }

        public bool IsEmpty()
        {
            return point == -1;
        }

        public void Clear()
        {
            point = -1;
        }

        public void Push(T item)
        {
            if (point < arr.Length - 1)
            {
                point++;
                arr[point] = item;
            }
            else
            {
                Console.WriteLine("full");
            }
        }

        public T Pop()
        {
            if (point == -1)
            {
                Console.WriteLine("empty");
                return default(T);
            }
            else
            {
                T temp = arr[point];
                point--;
                return temp;
            }
        }

        public T Peek()
        {
            if (point != -1)
            {
                return arr[point];
            }
            return default(T);
        }
    }
}
