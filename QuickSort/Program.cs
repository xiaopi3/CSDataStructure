using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 7, 10, 3, 5, 4, 6, 2, 8, 1, 9 };
            Sort(a, 0, 9);
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.ReadKey();
        }

        private static void Sort(int[] a, int ind_i, int ind_j)
        {
            if (ind_j!=ind_i)
            {
                int X = a[ind_j];
                int m = fastSort(a, ind_i, ind_j);
                int temp = a[m];
                a[m] = a[ind_j];
                a[ind_j] = temp;
                if (m == ind_i)
                {
                    Sort(a, m + 1, ind_j);
                }
                else if (m == ind_j)
                {
                    Sort(a, ind_i, m - 1);
                }
                else
                {
                    Sort(a, ind_i, m - 1);
                    Sort(a, m + 1, ind_j);
                }
            }

        }

        private static int fastSort(int[] a, int ind_i, int ind_j)
        {

            int X = a[ind_j];
            int r=ind_j;
            for(int i = ind_i; i <= ind_j; i++)
            {
                if (a[i] > X)
                {
                    if (i == ind_j)
                    {
                        return i;
                    }
                    
                    for (int j = r; j >= i; j--)
                    {
                        if (i == j)
                        {
                            return i;
                        }
                        if (a[j] < X)
                        {
                            r = j-1;
                            ind_j = j;
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                            break;
                        }
                    }
                }
            }
            return ind_j;
        }
    }
}
