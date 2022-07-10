using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC.StringPrograms
{
    class DemoString
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            String str = "this the string";
            Console.WriteLine("{0}\n{1}",s,str);

            string fname = "beba";
            string lname = "biradar";
            string fullname = String.Concat(fname, lname);
            //string fullname = string.Concat(fname, lname);
            Console.WriteLine(fullname);
        }
    }
  //string Methods

     class Program1
     {
        static void Main(string[] args)
        {
            string s = "beba is developer at prorigo";
            int l = s.Length;
            Console.WriteLine("lLemgth is " +l);
        }
     }

    class IndexOfDemo//(string)
    {
        static void Main(string[] args)
        {
            string s1 = "hello my programing";
            int x = s1.IndexOf('r');
            Console.WriteLine(s1 + " " + x);

        }
    }
    class LastIndexOfDemo//(char)
    {
        static void Main(string[] args)
        {
            string s1 = "hello my programing";
            int x = s1.LastIndexOf('g');
            Console.WriteLine(s1 + " " + x);
        }
    }

    class ConcatDemo
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string s = String.Concat(str, "pune");
            Console.WriteLine(s+" "+str);


            string s1 = "beba";
            string s2 = "biradar";
            string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
        }
    }

    class SubStringDemo//(Int32)
    {
        static void Main(string[] args)
        {
            string s1 = "hello my programing";
            string s2 = s1.Substring(4);
            Console.WriteLine(s2);
        }
    }

    class SplitDemo//Split(char[])
    {
        static void Main(string[] args)
        {
            string s1 = "java,c sharpe,c++";
            string[] s2 = s1.Split(",");
            foreach(string ss in s2)
            {
                Console.WriteLine(ss);
            }
            
        }
    }

    class JoinDemp//foreach
    {
        static void Main(string[] args)
        {
            string s1 = "java,c,c++";
            string[] s2 = s1.Split(",");
            foreach(string  ss in s2)
            {
                Console.WriteLine(ss);
            }
            Console.WriteLine(string.Join(" ","pune","welcome"," ","pune"," ","welcome" ));
        }
    }


    class TrimeDemo//remove whitespace
    {
        static void Main(string[] args)
        {
            string s1 = "   pune";
            Console.WriteLine(s1);
            Console.WriteLine(s1.Trim());
        }
    }

    class TouuperTolowerDemo
    {
        static void Main(string[] args)
        {
            string s1 = "WELCOME TO BIDAR";
            string s2 = "welcome to prorigo";
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s2.ToUpper());
        }
    }
}
