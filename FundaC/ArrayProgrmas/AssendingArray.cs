using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class AssendingArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
