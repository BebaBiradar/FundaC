using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class Vowels
    {
        static void Main(string[] args)
        {
            string str = "beba";
            int vovelscount = 0, conscount = 0;
            int len = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'e' || str[i] == 'A' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' || str[i] == 'E')
                {
                    vovelscount++;

                }
                else
                {
                    conscount++;
                }
            }
            Console.WriteLine(vovelscount);

        }
    }
}
