using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Evennumber1ton
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            Console.WriteLine("enter the number:");
            int i = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for(i=1;i>=n;i++)
            {
              if(i%2==0)
                {
                    Sum = Sum + i;
                }
            }
            Console.WriteLine("sum of all even number between 1 to n =n,Sum:");

        }
    }
}
