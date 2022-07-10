using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Divisibleby5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number:");
            int num = int.Parse(Console.ReadLine());
            if((num%5  == 0) && (num%11 == 0))
            {
                Console.WriteLine("The given number is divisble by 5 and 11");
            }
            else
            {
                Console.WriteLine("The given number is not divisible by 5 and 11");
            }
        }
    }
}
