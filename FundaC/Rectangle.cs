using System;
using System.Collections.Generic;
using System.Text;

namespace FundaC
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the rectangle:");
            double height = double.Parse(Console.ReadLine());

            double area = height * width;
            double permiter = 2 * (height + width);

            Console.WriteLine("Area:{0}, area:");
            Console.WriteLine("Perimeter:{0}", permiter);
        }
    }
}
