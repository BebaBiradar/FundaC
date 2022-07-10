using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class Pattern_String
    {
        static void Main(string[] args)
        {
            string str = "i like india";
            string[] s = str.Split(" ");
            for (int i = 0; i <= str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
