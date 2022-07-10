using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Alphabetusingforloop
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Display  all alphabets from a-z are:");
            char ch = char.Parse(Console.ReadLine());
            for(ch='a';ch<='z';ch++)
            {
                Console.WriteLine(ch +"");
            }
        }
    }
}
