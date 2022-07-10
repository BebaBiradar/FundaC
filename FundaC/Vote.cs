using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Vote
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            byte age = byte.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("u are eligible for vote");
            }
            else
            {

                Console.WriteLine("u are not eligible for vote");
            }

        }
        
    }
}
