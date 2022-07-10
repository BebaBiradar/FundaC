using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class PositeveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("number is positive");
            }
            if(num<0)
            {
                Console.WriteLine("number is negative");
            }
            if (num == 0)
            {
                Console.WriteLine("number is zero");
            }
        }
    }
}
