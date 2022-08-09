using System;

namespace sphere_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type radius of sphere:");
            int radius = Int32.Parse(Console.ReadLine());

            double area = 2 * Math.PI * radius * radius;
            // Math.Pow(base, exponent)
            double area2 = 2 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the sphere is " + area);
            Console.WriteLine("The area of the sphere is " + area2);

            double volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("The volume of the sphere is " + volume);

            Console.ReadLine();
        }
    }
}
