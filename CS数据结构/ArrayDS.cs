using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS数据结构
{
    class ArrayDS<T> : IList<T>
    {
        private int count;
        private T[] data;
        public ArrayDS() : this(10)//构造函数不用带T泛型
        {

        }
        public ArrayDS(int size)
        {
            count = 0;
            data = new T[size];
        }

        public T this[int index] => GetEle(index);

        public void Add(T item)
        {
            if (count == data.Length) return;
            data[count] = item;
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
                T temp = data[index];
                for (int i = index; i < count - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
                return temp;
            }
            Console.WriteLine("no such element!");
            return default(T);
        }

        public T GetEle(int index)
        {
            if (index >= 0 && index < count)
            {
                return data[index];
            }
            Console.WriteLine("no such element!");
            return default(T);
        }

        public int GetLength()
        {
            return count;
        }

        public void Insert(T item, int index)
        {
            if (count == data.Length) return;
            if (index >= 0 && index < count)
            {
                for (int i = count - 1; i >= index; i--)
                {
                    data[i + 1] = data[i];
                }
                data[index] = item;
            }
            else
            {
                Console.WriteLine("out bound of index!");
            }
            count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Locate(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if (item.Equals(data[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
