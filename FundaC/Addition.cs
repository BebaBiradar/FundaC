using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Addition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            int sum = a + b;
            Console.WriteLine("sum=" + (a + b));
        }

    }
}
