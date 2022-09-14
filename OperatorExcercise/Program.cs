using System;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExcercise
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine(a + " / " + b + " is " + quotient + " remainder " + remainder);

            Console.WriteLine("Enter the radius of the circle");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
