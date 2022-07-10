using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Squares
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "enter number from 1 to 20:");
            int i = int.Parse(Console.ReadLine());
            for(i=1;i<=20;i=i*i)
            {
                Console.WriteLine(i+"i*i");
            }
        }
    }
}
