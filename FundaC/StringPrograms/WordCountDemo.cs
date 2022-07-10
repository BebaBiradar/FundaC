using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class WordCountDemo
    {
        static void Main(string[] args)
        {
            string str = "india is good country";
            int count = 0;
            for(int i=0;i<str.Length-1;i++)
            {
                if (str[i] == ' ' && Char.IsLetter(str[i + 1]) && (i > 0))
                    count++;     
            }
            count++;
            Console.WriteLine("total number of words:"+count);
        }
    }
}
