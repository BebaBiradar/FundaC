using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Break
    {
        static void Main(string[] args)
        {
            int i;
            i = int.Parse(Console.ReadLine());
            for(i=0;i<10;i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    break;
            }
            Console.WriteLine("come outside loop, i");
        }
    }
}
