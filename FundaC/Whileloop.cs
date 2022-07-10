using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Whileloop
    {
        static void Main(string[] args)
        {
            int number = 521,n=221;
            Console.WriteLine("Enter number from 521 to 221:");
            number = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            while(number<=n)
            {
                if(number%2!=0)
                    Console.WriteLine(number +"");
            }
                
        }
    }
}

