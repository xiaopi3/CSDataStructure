using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列.练习
{
    class ArrayDS<T> : IList<T>
    {
        private int count;
        private T[] arr;

        public ArrayDS(int size)
        {
            count = 0;
            arr = new T[size];
        }
        public ArrayDS()
        {
            count = 0;
            arr = new T[10];
        }
        public T this[int index]
        {
            get
            {
                return GetEle(index);
            }
        }

        public void Add(T item)
        {
            if (count == arr.Length)
            {
                Console.WriteLine("full-can not add");
                return;
            }
            arr[count] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public T Delete(int index)
        {
            if (index >= 0 && index < count)
            {
                T temp = arr[index];
                for (int i = index; i < count-1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                count--;
                return temp;
            }
            Console.WriteLine("index out of bounds");
            return default(T);
        }

        public T GetEle(int index)
        {
            if(index >= 0 && index < count)
            {
                return arr[index];
            }
            Console.WriteLine("index out of bounds");
            return default(T);
        }

        public int GetLength()
        {
            return count;
        }

        public void Insert(T item, int index)
        {
            if (index >= 0 && index < count)
            {
                arr[index] = item;
                count++;
            }
            else
                Console.WriteLine("index out of bounds");
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Locate(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if (arr[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
