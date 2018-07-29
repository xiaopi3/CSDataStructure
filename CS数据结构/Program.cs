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
            //ArrayDS<String> arr = new ArrayDS<string>();
            //LinkedDS<String> arr = new LinkedDS<string>();

            //测试1
            //练习.ArrayDS<String> arr = new 练习.ArrayDS<string>();
            练习.LinkedDS<String> arr = new 练习.LinkedDS<string>();
            arr.Add("123");
            arr.Add("432");
            arr.Add("888");
            for (int i = 0; i < arr.GetLength(); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr.Delete(0);
            for(int i = 0; i < arr.GetLength(); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr.Insert("000", 1);
            for (int i = 0; i < arr.GetLength(); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(arr.IsEmpty());

            arr.Clear();
            Console.WriteLine(arr.IsEmpty());

            Console.ReadKey();
        }
    }
}
