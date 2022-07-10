using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class SumOfArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }
    }

    
}
