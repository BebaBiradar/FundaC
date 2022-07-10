using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            for(int divisor=1;divisor<=a;divisor++)
                {
                if(a%divisor==0)
                {
                    Console.WriteLine("facto =" + divisor);
                }
            }
            
                

        }
    }
}
