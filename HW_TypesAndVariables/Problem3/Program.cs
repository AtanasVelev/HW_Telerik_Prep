using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problem 3.Circle Perimeter and Area
            //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
            //Examples:
            // r perimeter           area
            //2   12.57   12.57
            //3.5 21.99   38.48
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * (r * r);
            double perimeter = 2 * (pi * r);
            Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
        }
    }
}
