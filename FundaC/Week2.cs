using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Week2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter week name:");
            int week = int.Parse(Console.ReadLine());
            if(week == 1)
            {
                Console.WriteLine("monday");
            }
            else if(week == 2)
            {
                Console.WriteLine("tuesday");
            }
            else if(week == 3)
            {
                Console.WriteLine("wednesday");
            }
            else if (week == 4)
            {
                Console.WriteLine("thursday");
            }
            else if (week == 5)
            {
                Console.WriteLine("friday");
            }
            else if(week == 6)
            {
                Console.WriteLine("saturday");
            }
            else if(week == 7)
            {
                Console.WriteLine("sunday");
            }
            else

            {
                Console.WriteLine("invalid");
            }

            

           

        }
    }
}
