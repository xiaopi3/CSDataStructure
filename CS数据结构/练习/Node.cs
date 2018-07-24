using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS数据结构.练习
{
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public T Data { get => data; set => data = value; }
        internal Node<T> Next { get => next; set => next = value; }

        public Node()
        {
            data = default(T);
            next = null;
        }
        public Node(T item)
        {
            data = item;
            next = null;
        }
        public Node(Node<T> next)
        {
            data = default(T);
            this.next = next;
        }
        public Node(T item, Node<T> next)
        {
            data = item;
            this.next = next;
        }
    }
}
