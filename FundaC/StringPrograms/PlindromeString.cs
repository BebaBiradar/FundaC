using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class PlindromeString
    {
        static void Main(string[] args)
        {
            /*string str = "";
            Console.WriteLine("eneter the strong");
            string s = Console.ReadLine();*/
           string s = "beb";
            string str = "";
            int len =s.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                str = str + s[i];
            }
            if (str == s)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }

    }

}
