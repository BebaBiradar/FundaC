using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Doller
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount");
            int amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter dollere and pounds amount");
            string str = Console.ReadLine();
            switch(str)
            {
                case "doller":
                    amt = amt / 77;
                    Console.WriteLine("The amount in doller is:" +amt);
                    break;
                case "pounds":
                    amt = amt / 95;
                    Console.WriteLine("The amount in pound is:" +amt);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

    }
}
