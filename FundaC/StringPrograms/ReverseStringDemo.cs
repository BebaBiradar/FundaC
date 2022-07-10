using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class ReverseStringDemo  //ynapmoc doog si ogirorp
    {
        static void Main(string[] args)
        {
            string st = "prorigo is good company";
            string reverse = " ";
            for(int i=0;i<st.Length;i++)
            {
                reverse = st[i] + reverse;
            }
            Console.WriteLine(reverse);
        }
    }



}
