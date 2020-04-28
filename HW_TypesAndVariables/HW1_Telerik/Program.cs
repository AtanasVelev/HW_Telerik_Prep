using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1.Sum of 3 Numbers
            //Write a program that reads 3 int numbers from the console and prints their sum.
            //Examples:
            //a b           c sum
            //3   4   11  18
            //- 2  0   3   1
            //5   4   20  29

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine(sum);

            
        }
    }
}
