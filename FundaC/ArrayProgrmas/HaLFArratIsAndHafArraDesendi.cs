using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.ArrayProgrmas
{
    class HaLFArratIsAndHafArraDesendi
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 ,6};
            for(int i=0;i<a.Length/2;i++) 
            {
                for(int j=0;j<a.Length/2;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }
                }
                
                    
            }
            Console.WriteLine(string.Join("", a));
        }
        
    }
}
