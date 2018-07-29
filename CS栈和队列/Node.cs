using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    class Node<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        private Node<T> next;

        internal Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

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

    }
}
