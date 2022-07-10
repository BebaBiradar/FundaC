using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class Togglecase
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("eneter the string");//user se
            string str = Console.ReadLine();*/


            string str = "biradar"; //hard value
            string newstr = " ";
            for (int i = 0; i < str.Length;i++)
            {
                char ch = str[i];
                if(Char.IsUpper(ch))
                {
                    ch = (char)(ch + 32);
                }
                else if(Char.IsLower(ch))
                {
                    ch = (char)(ch - 32);
                }
                newstr = newstr + ch;
            }
            Console.WriteLine(newstr);
            
        }
        
    }
}
