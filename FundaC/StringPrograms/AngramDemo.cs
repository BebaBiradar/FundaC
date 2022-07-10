using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class AngramFun1
    {
        public void Anastringq1(string s1, string s2)
        {
            string st1 = s1.ToLower();
            string st2 = s2.ToLower();

            char[] ch1 = st1.ToCharArray();
            char[] ch2 = st2.ToCharArray();
            if (ch1.Length == ch2.Length)
            {
                //sort logic
                Array.Sort(ch1);
                Array.Sort(ch2);

                string str1 = new string(ch1);
                string str2 = new string(ch2);

                if (str1.Equals(str2))
                {
                    Console.WriteLine("yes:");
                }
                else
                {
                    Console.WriteLine("not");
                }
            }
            else
            {
                Console.WriteLine("string length is not same");
            }
        }
        static void Main(string[] args)
        {

            /*Console.WriteLine("enter frist string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter second string");
            string s2 = Console.ReadLine();
            AngramFun1 a = new AngramFun1();
            a.Anastringq1(s1, s2);*/
            AngramFun1 a = new AngramFun1();
            a.Anastringq1("build", "duild");

        }
    }



    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string s2 = Console.ReadLine();

            string st1 = s1.ToLower();
            string st2 = s2.ToLower();

            char[] ch1 = st1.ToCharArray();
            char[] ch2 = st2.ToCharArray();
            if (ch1.Length == ch2.Length)
            {
                //sort logic
                Array.Sort(ch1);
                Array.Sort(ch2);

                string str1 = new string(ch1);
                string str2 = new string(ch2);

                if (str1.Equals(str2))
                {
                    Console.WriteLine("yes:");
                }
                else
                {
                    Console.WriteLine("not");
                }

            }
            else
            {
                Console.WriteLine("string length is not same");
            }

        }         
    }
}
