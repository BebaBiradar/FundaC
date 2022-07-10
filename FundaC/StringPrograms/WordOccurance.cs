using System;
using System.Text.RegularExpressions;

namespace FundaC.StringPrograms
{
    class WordOccurance
    {
        //Regular expressions are generally termed as c# Regex ..
        //RegexOptions.IgnoreCase will relax the requirement for an input with letters to be matched
        //thus, the iput string can have a capital or lowercase letter
        static void Main(string[] args)
        {
            string msg = "indiam,is, good,country,and,prorigo,is,good,comapny";
            int wordcount = 0;
            foreach (Match m in Regex.Matches(msg, "is"))
                // foreach (Match m in Regex.Matches(msg, "is",RegexOptions.IgnoreCase))
                //string msg = "indiam,is, GOOD,country,and,prorigo,IS,good,comapny";
            {
                wordcount++;
            }
            Console.WriteLine("total count:{0}",wordcount);
        }
    }
}
