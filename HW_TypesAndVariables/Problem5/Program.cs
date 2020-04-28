using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 5.Quadratic Equation
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 +bx + c = 0 and solves it(prints its real roots).
            //Asume there always will be one or two real roots(b2 -4ac >= 0)
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double sqrtpart = (b * b) - (4 * a * c);
            double x1 = 0;
            double x2 = 0;
            if (sqrtpart >= 0)
            {
                x1 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                if (x1 == -0)
                {
                    x1 = 0;
                }
                x2 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                if (x2 == -0)
                {
                    x2 = 0;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("x1={0}; x2={1}", x1, x2);
        }
    }
}
