using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Buzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "enter the number:");
            int a = int.Parse(Console.ReadLine());
            if(a%10 ==7 || a%7 == 0)
            {
                Console.WriteLine("number is buzz number");
            }
            else
            {
                Console.WriteLine("number is not buzz no");
            }
        }
    }
}
