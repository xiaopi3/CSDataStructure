using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    interface IQueue<T>
    {
        int Count{get;}
        void Clear();
        bool IsEmpty();
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}
