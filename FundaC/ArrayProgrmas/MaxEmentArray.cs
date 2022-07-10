using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class MaxEmentArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }


    class MaxMin
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int max = a[0], min =a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
                if(a[i]<min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
