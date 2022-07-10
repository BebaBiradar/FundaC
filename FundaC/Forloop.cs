using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Forloop
    {
        static void Main(string[] args)
        {
            
           for (int  i= 1;i<= 10;i++)
                Console.WriteLine(i);

        }
    }
}

namespace FundaC
{
    class Reversenumber
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 1; i--)
                Console.WriteLine(i);
        }
    }
}

namespace FundaC
{
    class Even
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i = i + 2)
                Console.WriteLine(i);
        }
    }
}


namespace FundaC
{
    class Odd
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i = i + 2)
                Console.WriteLine(i);
        }
    }
}

namespace FundaC
{
    class TT
    {
        static void Main(string[] args)
        {
            int number = 229;
            Console.WriteLine("eneter the number between 121 to 229  to find eevn number:");
            
            number = int.Parse(Console.ReadLine());
            for (int i = 121; i<=number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                }
            }
        }
    }
}




