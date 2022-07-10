using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class UnionORmarging
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, };
            int[] arr2 = { 5, 6, 7, 8 };
            Console.WriteLine("array1...");
            foreach(int ele in arr1)
            {
                Console.Write(ele);
            }
            Console.WriteLine();
            Console.WriteLine("array2.....");
            foreach(int ele in arr2)
            {
                Console.Write(ele);
            }
            Console.WriteLine();
            


            var mylist = new List<int>();
            mylist.AddRange(arr1);
            mylist.AddRange(arr2);
            int[] arr3 = mylist.ToArray();

            Console.WriteLine("combined array element..");
            foreach(int res in arr3)
            {
                Console.Write(res);
            }
        }
    }

    class D
    {
        static int[] marge(int [] a,int[]b)
        {
            int j = 0;
            int[] c = new int[a.Length + b.Length];
            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;
            }
            for(int i=0;i<a.Length;i++)
            {
                c[j] = b[i];
                j++;
            }
            return c;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 5, 6 };
            int[] b = { 5, 6, 8, 9, 0,};
            int[] c = marge(a, b);
            for(int i=0;i<c.Length;i++)
            {
                Console.Write(c[i]+" ");
            }

        }
    }


}
