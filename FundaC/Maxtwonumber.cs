using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Maxtwonumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of y:");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }
        }
    }
}
