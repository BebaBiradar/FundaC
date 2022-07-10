using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("array length" + a.Length);
            int counteven = 0, countodd = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    counteven++;
                }
                else
                {
                    countodd++;
                }
            }
            Console.WriteLine("evenelement" + counteven, "odd element" + countodd);
        }
    }

    class SaperateEvenodd
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 7, 6 };
            Console.WriteLine("even element from the array");
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    
                    Console.Write(a[i]+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("odd elemnt from the array");
            for(int i=0;i<a.Length;i++)
            {
                if(a[i] % 2 != 0)
                {
                    Console.Write(a[i]+" ");
                }
            }
        }
    }

    class Even
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            for (int i = 1; i < a.Length;i=i+2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }


    class OddElme
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            for(int i=1;i<a.Length;i=i+2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
