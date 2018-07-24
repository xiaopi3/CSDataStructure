using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS数据结构
{
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node()
        {
            this.Data = default(T);
            this.Next = null;
        }
        public Node(T item)
        {
            this.Data = item;
            this.Next = null;
        }
        public Node(Node<T> next)
        {
            this.Next = next;
        }
        public Node(T item,Node<T> next)
        {
            this.Data = item;
            this.Next = next;
        }

        public T Data { get => data; set => data = value; }
        internal Node<T> Next { get => next; set => next = value; }
    }
}
