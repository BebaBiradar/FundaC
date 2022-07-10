using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class VowelsusingSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any character:");
            char nr = char.Parse(Console.ReadLine());
                
            switch(nr)
            {
                case 'a':
                    Console.WriteLine(" character is vowel");
                    break;
                case 'e':
                    Console.WriteLine(" character is vowel");
                    break;
                case 'i':
                    Console.WriteLine(" character is vowel");
                    break;
                case 'o':
                    Console.WriteLine("character is vowel");
                    break;
                case 'u':
                    Console.WriteLine(" character is vowel");
                    break;
                default :
                    Console.WriteLine("charecter is not vowels");
                    break;


            }
        }
    }
}
