using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            for(int i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    temp = 1;
                }
            }
            if(temp==0)
            {
                Console.WriteLine("it is prime number");
            }
            else
            {
                Console.WriteLine("it is not prime number");
            }
        }

    }
}
