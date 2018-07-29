using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    interface IStack<T>
    {
        int Count { get; }
        bool IsEmpty();
        void Clear();
        void Push(T item);
        T Pop();
        T Peek();
    }
}
