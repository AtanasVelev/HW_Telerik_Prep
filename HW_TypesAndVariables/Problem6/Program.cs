using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 6.Sum of 5 Numbers
            //Write a program that enters 5 numbers(each number will be on a separate / new line), calculates and prints their sum.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}
