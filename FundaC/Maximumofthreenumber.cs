using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Maximumofthreenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    max = n1;
                }
                else
                {
                    max = n3;
                }
            }
            else
            {
                if (n2 > n3)
                {
                    max = n2;
                }
                else
                {
                    max = n3;
                }

            }

            Console.WriteLine("max among all there numbers is:", max);
        }

    }
}
