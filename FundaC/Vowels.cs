using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value:");
            char p = char.Parse(Console.ReadLine());
            if (p == 'a' || p == 'e' || p == 'i' || p == 'o' || p == 'u')
            {
                Console.WriteLine("value is vowel");
            }
            else
            {
                Console.WriteLine("value is consonant");
            }
        }
    }
}
