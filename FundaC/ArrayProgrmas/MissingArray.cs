using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class MissingArray
    {

        static void finEl(int[] a)
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
            int[] a = { 2, 3, 4, 5, 6, 7, 8, 9 };
            finEl(a);
        }
    }
}
