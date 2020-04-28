using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 7.Sum of greatest and smallest
            //Write a program that enters 3 numbers(each number will be on a separate / new line), calculates and prints the sum of the greatest and smallest of them.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (a >= b && a >= c && b >= c)
            {
                sum = a + c;
            }
            else if (a >= b && a >= c && b <= c)
            {
                sum = a + b;
            }
            else if (b >= a && b >= c && a >= c)
            {
                sum = b + c;
            }
            else if (b >= a && b >= c && a <= c)
            {
                sum = b + a;
            }
            else if (c >= a && c >= b && a >= b)
            {
                sum = c + b;
            }
            else if (c >= a && c >= b && a <= b)
            {
                sum = c + a;
            }
            Console.WriteLine(sum);
        }
    }
}
