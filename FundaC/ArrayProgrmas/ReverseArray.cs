using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int j = a.Length - 1;
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join("",a));
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'v', 's', 'f' };
            
            int j = ch.Length - 1;
            for(int i=0;i<args.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
                
            }
            Console.WriteLine(string.Join(" ",ch));
        }
    }
    class Demo1
    {
        static void Main(string[] args)
        {
            int[] a= { 1, 2, 3, 4 };
            Array.Reverse(a);
            Console.WriteLine(string.Join("",a));
        }
    }

    class RevesrNumber
    {
        static void Main(string[] args)
        {
            int []a= { 1, 2, 3, 4 };
            foreach(int aa in a)
            {
                Console.Write(aa);
            }
            Console.WriteLine();
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.Write(string.Join("",a[i]));
            }
        }
    }
}
