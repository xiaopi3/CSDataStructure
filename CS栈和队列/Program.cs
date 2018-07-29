using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS栈和队列
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayStackDS<int> test = new ArrayStackDS<int>();
            //LinekedStackDS<int> test = new LinekedStackDS<int>();
            //LinekedStackDS<int> test = new LinekedStackDS<int>();
            LinkedQueueDS<int> test = new LinkedQueueDS<int>();

            //test.Push(11);
            test.Enqueue(11);
            Console.WriteLine(test.Count);
            //test.Push(12);
            test.Enqueue(12);
            Console.WriteLine(test.Count);
            //test.Push(131);
            test.Enqueue(123);
            Console.WriteLine(test.Count);


            //Console.WriteLine(test.Pop());
            Console.WriteLine(test.Dequeue());
            //Console.WriteLine(test.Count);
            //Console.WriteLine(test.Pop());
            Console.WriteLine(test.Dequeue());
            //Console.WriteLine(test.Count);
            //Console.WriteLine(test.Pop());
            Console.WriteLine(test.Dequeue());
            //Console.WriteLine(test.Count);

            Console.WriteLine(test.Dequeue());
            //Console.WriteLine(test.Count);

            Console.WriteLine(test.IsEmpty());

            test.Enqueue(11);
            //Console.WriteLine(test.Count);


            test.Clear();
            Console.WriteLine(test.IsEmpty());

            Console.ReadKey();
        }
    }
}
