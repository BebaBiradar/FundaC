using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Factorial1_2_
    {
        static void Main(string[] args)
        {
            int n, i=300, m=400 ;
            int flag = 0;
            Console.WriteLine("enter the number to check prime:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for(i=300;i<=m;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("number is not  prime number:");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
                Console.WriteLine("number is prime:");
        }
    }
 

}
