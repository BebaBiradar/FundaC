using System;


namespace FundaC.PtternProgram
{
    class Program1
    {
        static void Main(string[] args)
        {
          for(int i=1;i<=4;i++)
          {
                for(int j=1;j<=4;j++)
                {
                    Console.WriteLine(i+" ");//(j+" ");
                }
          }
            Console.ReadLine();
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j + " ");//(j+" ");
                }
            }
            Console.ReadLine();
        }
    }
     

    class Program3
    {
        static void Main(string[] args)
        {
            int c = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(c);
                    c++;
                }
                Console.WriteLine();
            }
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            for(int i=1;i<=5;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                    Console.WriteLine("{0}",k++);
                    Console.WriteLine("\n");
                }
                
            }
            Console.ReadLine();
        }
    }

    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i=1;i<=9;i++)
            {
               
                for(int j=1;j<=(x-i);j++)
                {
                    for(int number=1;number<=i;number++)
                    {
                        Console.Write(number);
                    }
                    for(int Number=(i-1);Number>=1;Number--)
                    {
                        Console.Write(Number);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }


    class TringleNumeber
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");//(k)
                }
                for(int l=i-1;l>=1;l--)
                {
                    Console.Write("*");//(l)
                }
                Console.WriteLine("\n");
            }
        }
    }
   class Program5
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("{0}",k++);
                    Console.WriteLine("\n");
                }
                
            }
            
        }
    }


    class Program6
    {
        static void Main(string[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");//(j)
                }
                Console.WriteLine();
            }
            
        }
    }

    class Program7
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    

    class Program8
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");//(j)
                }
                Console.WriteLine();
            }
        }
    }

    class Program9//triangle
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("enetr the number of line");
            int n = int.Parse(Console.ReadLine());*/
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(j == 1||j == i||i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


    class Program10//n pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j == 5 || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


    class Program11
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int k=i;k<=5;k++)
                {
                    Console.Write(" ");
                }
                for(int j=i;j>=1;j--)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }

    class Program12
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=(5-i);j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<i*2;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class Program13
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j>i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
