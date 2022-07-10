using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Print1to5inwords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers:");
            char digite = char.Parse(Console.ReadLine());
            switch (digite)
            {
                case '0':
                    Console.WriteLine("zero");
                    break;
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("print all numbers:");
                    break;
            }
        }
    }
}
