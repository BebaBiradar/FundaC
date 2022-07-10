using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class MissingNumberArray
    {
        //function to find missing number
        static int getMissingNumber(int [] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;
            for(int i=0;i<n;i++)
            total = total - a[i];
            return total;
        }
        //program to test above function
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 6, 7, 8 };
            /* int miss = getMissingNumber(a, 5);
            Console.WriteLine(miss);*/
            Console.WriteLine(getMissingNumber(a,5));

        }
    }

    class Miss
    {
        static void findel(int[] a)
        {
            int total = (a[a.Length - 1]) * (a[a.Length - 1] + 1) / 2;
            Console.WriteLine(total);
            for(int i=0;i<a.Length;i++)
            {
                total = total - a[i];

            }
            Console.WriteLine(total);
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 6, 7, 8, };
            findel(a);
        }


    }

}
