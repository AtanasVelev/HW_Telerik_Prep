using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 4.Number Comparer
            //Write a program that gets two numbers from the console and prints the greater of them.Try to implement this without if statements.
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            bool greater = a > b;

            var result = greater ? a : b;
            Console.WriteLine(result);
        }
    }
}
